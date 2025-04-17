using AutoMapper;
using GeekShopping.CartAPI.Data.ValueObjects;
using GeekShopping.CartAPI.Model;
using GeekShopping.CartAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.CartAPI.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public CartRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CartVO> FindCartByUserId(string userId)
        {
            Cart cart = new Cart()
            {
                CartHeader = await _context.CartHeaders.FirstOrDefaultAsync(c => c.UserId == userId)
            };

            cart.CartDetails = await _context.CartDetails
                .Where(c => c.CartHeaderId == cart.CartHeader.Id)
                .Include(c => c.Product)
                .ToListAsync();

            return _mapper.Map<CartVO>(cart);
        }

        public async Task<CartVO> SaveOrUpdateCart(CartVO vo)
        {
            Cart cart = _mapper.Map<Cart>(vo);
            var cartDetail = cart.CartDetails.FirstOrDefault();

            if (cartDetail == null)
            {
                return _mapper.Map<CartVO>(cart);
            }

            var product = await _context.Products.FindAsync(cartDetail.ProductId);
            if (product == null)
            {
                _context.Products.Add(cartDetail.Product);
                await _context.SaveChangesAsync();
            }

            var cartHeader = await _context.CartHeaders
                .FirstOrDefaultAsync(c => c.UserId == cart.CartHeader.UserId);

            if (cartHeader == null)
            {
                //_context.CartHeaders.Add(cart.CartHeader);
                cartDetail.CartHeaderId = cart.CartHeader.Id;
                cartDetail.Product = null;
                _context.CartDetails.Add(cartDetail);

                await _context.SaveChangesAsync();
            }
            else
            {
                _context.Entry(cart.CartHeader).State = EntityState.Detached;

                var existingDetail = await _context.CartDetails.AsNoTracking().FirstOrDefaultAsync(
                   p => p.ProductId == cart.CartDetails.FirstOrDefault().ProductId &&
                   p.CartHeaderId == cartHeader.Id);

                if (existingDetail == null)
                {
                    cartDetail.CartHeaderId = cartHeader.Id;
                    cartDetail.Product = null;
                    cartDetail.CartHeader = null;

                    _context.CartDetails.Add(cartDetail);
                }
                else
                {
                    existingDetail.Count += cartDetail.Count;
                    _context.CartDetails.Update(existingDetail);
                }

                await _context.SaveChangesAsync();
            }

            return _mapper.Map<CartVO>(cart);
        }

        public async Task<bool> RemoveFromCart(long cartDetailsId)
        {
            try
            {
                CartDetail cartDetail = await _context.CartDetails
                    .FirstOrDefaultAsync(c => c.Id == cartDetailsId);

                int total = _context.CartDetails.Where(c => c.CartHeaderId == cartDetail.CartHeaderId)
                    .Count();

                _context.CartDetails.Remove(cartDetail);

                if (total == 1)
                {
                    var cartHeaderToRemove = await _context.CartHeaders
                        .FirstOrDefaultAsync(c => c.Id == cartDetail.CartHeaderId);

                    _context.CartHeaders.Remove(cartHeaderToRemove);
                }

                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> ApplyCoupon(string userId, string couponCode)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RemoveCoupon(string userId)
        {
            throw new NotImplementedException();
        }
         
        public async Task<bool> ClearCart(string userId) 
        {
            var cartHeader = await _context.CartHeaders
                        .FirstOrDefaultAsync(c => c.UserId == userId);

            if (cartHeader != null)
            {
                _context.CartDetails
                    .RemoveRange(
                    _context.CartDetails.Where(c => c.CartHeaderId == cartHeader.Id));

                _context.CartHeaders.Remove(cartHeader);

                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

    }
}
