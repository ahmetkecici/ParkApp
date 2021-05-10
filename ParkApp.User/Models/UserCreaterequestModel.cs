using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParkApp.User.Models
{
    public class UserCreaterequestModel
    {
        [Required(ErrorMessage = "NameSurname_Required")]
        [DisplayName("Name_Surname")]
        public string Name { get; set; }

    }
}
