using GeekShopping.CartAPI.Model;

namespace GeekShopping.CartAPI.Data.ValueObjects
{
    public class CartVO
    {
        public CartHeader CartHeader { get; set; }
        public IEnumerable<CartDetail> CartDetails { get; set; }
    }
}
