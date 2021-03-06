﻿using PetShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.ApplicationServices
{
    public interface IOwnerService
    {

        public List<Owner> ReadOwners();
        public Owner getOwner(Pet p);
        public Owner DeleteOwner(Owner o);
        public Owner UpdateOwner(Owner o);
        public Owner CreateOwner(Owner o);
    }
}
