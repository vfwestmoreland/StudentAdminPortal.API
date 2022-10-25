﻿namespace StudentAdminPortal.API.DomainModels
{
    public class StudentDto
    {
        //public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public long PhoneNumber { get; set; }

        public Guid GenderId { get; set; }

        public GenderDto Gender { get; set; }

        public AddressDto Address { get; set; }
    }
}
