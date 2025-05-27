using System;
using System.Collections.Generic;

namespace Final.Models;

public partial class User
{
    public long Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Gender { get; set; }

    public DateOnly Birthday { get; set; }

    public long StuPerCode { get; set; }

    public long NationalCode { get; set; }

    public long Phone { get; set; }

    public string Address { get; set; } = null!;

    public DateTime? LastLogin { get; set; }

    public DateTime? PreviousLogin { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<Block> Blocks { get; set; } = new List<Block>();

    public virtual ICollection<Dormitory> Dormitories { get; set; } = new List<Dormitory>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public virtual ICollection<RoomAssigment> RoomAssigments { get; set; } = new List<RoomAssigment>();

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();

    public virtual ICollection<StudentAsset> StudentAssets { get; set; } = new List<StudentAsset>();

    public virtual ICollection<SubstituteStudentAsset> SubstituteStudentAssets { get; set; } = new List<SubstituteStudentAsset>();

    public virtual ICollection<TransferRoomAssetHistory> TransferRoomAssetHistories { get; set; } = new List<TransferRoomAssetHistory>();
}
