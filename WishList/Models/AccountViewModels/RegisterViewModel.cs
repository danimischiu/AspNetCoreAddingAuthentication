using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WishList.Models.AccountViewModels
{
    public class RegisterViewModel
    {
		[Required]
        public string Email { get; set; }

		[Required][StringLength(maximumLength:100, MinimumLength = 8)][DataType(dataType: DataType.Password)]
        public string Password { get; set; }

		[Required][Compare(otherProperty:nameof(Password))][DataType(dataType: DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}
