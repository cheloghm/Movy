﻿using Movy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movy.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "Please enter customer's name.")] 
        [Required, StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        //public MembershipType MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }

        //[Display(Name = "Membership Type")] 
        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}