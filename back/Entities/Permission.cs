﻿using back.Entities.Common;
using back.Enums;

namespace back.Entities
{
    public class Permission : BaseEntity
    {
        public int DaysAmount { get; set; }

        public Status Status { get; set; }

        public string ProfileId { get; set; }
        public UserProfile Profile { get; set; }

        public string PermissionTypeId { get; set; }
        public PermissionType PermissionType { get; set; }

    }
}
