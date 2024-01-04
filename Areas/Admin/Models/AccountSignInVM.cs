using System.ComponentModel.DataAnnotations;

namespace Amado.Areas.Admin.Models
{
    public class AccountSignInVM
    {

        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}