using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;

namespace Final.Models;

public partial class Dormitory
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public long Capacity { get; set; }
    public long NowCapacity { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeletedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public long CreatBy { get; set; }

    public DateTime CreatOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
    public int DormitoryGender { get; set; }

    public virtual ICollection<Block> Blocks { get; set; } = new List<Block>();

    public virtual User CreatByNavigation { get; set; } = null!;

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public static int FindDormitoryType(long RoomId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        return db.Dormitories.Where(i => i.Id == Block.FindBlockById(Room.FindBlockId(RoomId)).DermitoryId).FirstOrDefault().DormitoryGender;
    }
    public static Dormitory? FindDormitoryById(long DormitoryId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        return db.Dormitories.Where(i => i.Id == DormitoryId).FirstOrDefault();
    }
    public static bool AnyDormitory(string DormitoryName)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        return db.Dormitories.Any(i => i.Name == DormitoryName);
    }
    public static void SetDormitory(string Name, string Address, int Capacity, long UserId, int DormitoryGender)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        Dormitory dormitory = new Dormitory();
        dormitory.Name = Name;
        dormitory.Capacity = Capacity;
        dormitory.Address = Address;
        dormitory.IsDeleted = false;
        dormitory.CreatBy = UserId;
        dormitory.CreatOn = DateTime.Now;
        dormitory.DormitoryGender = DormitoryGender;

        db.Dormitories.Add(dormitory);
        db.SaveChanges();
    }
    public static void EditDormitory(long DormitoryEditId, long UserId, string Name, string Address, int Capacity, int DormitoryGender)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        Dormitory? dormitory = new Dormitory();
        dormitory = Dormitory.FindDormitoryById(DormitoryEditId);
        db.Dormitories.Update(dormitory);

        dormitory.Name = Name;
        dormitory.Capacity = Capacity;
        dormitory.Address = Address;
        dormitory.ModifiedBy = UserId;
        dormitory.ModifiedOn = DateTime.Now;
        dormitory.DormitoryGender = DormitoryGender;

        db.SaveChanges();
    }
    public static string? FindDormitoryOwnerName(long DormitoryId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        var user = User.FindUserById(db.Roles.Where(i => i.DermitoryId == DormitoryId).FirstOrDefault().Id);
        return (user?.FirstName + " " + user?.LastName) ?? "";
    }
    public static List<RoomAssigment>? FindStudents(long DormitoryId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        List<Block> blocks = Block.FindByDormitoryId(DormitoryId);
        List<RoomAssigment> RoomAssigments = new List<RoomAssigment>();

        foreach (Block b in blocks)
            foreach (Room r in Room.FindByBlockId(b.Id))
                foreach (RoomAssigment rs in RoomAssigment.FindByRoomId(r.Id))
                    RoomAssigments.Add(rs);


        return RoomAssigments;
    }
    public static void DeleteDormitory(long UserDeletedId, long DormitoryId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        Models.Dormitory dormitory = Models.Dormitory.FindDormitoryById(DormitoryId);
        db.Dormitories.Update(dormitory);
        dormitory.IsDeleted = true;
        dormitory.DeletedBy = UserDeletedId;
        dormitory.DeletedOn = DateTime.Now;
        db.SaveChanges();
    }









}
