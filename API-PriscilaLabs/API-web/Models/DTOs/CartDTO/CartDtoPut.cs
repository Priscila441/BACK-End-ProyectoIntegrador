using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_web.Models.DTOs.CartDTO
{
    public class CartDtoPut
    {
        public int IdCart { get; set; }
        public bool EmptyCart { get; set; } = false; //Nos sirve en un futuro para vaciar el carrito 
    }
}
