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
    public static void SetDormitory(string Name , string Address, int Capacity, long UserId , int DormitoryGender)
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
    public static void EditDormitory(long DormitoryEditId, long UserId, string Name, string Address, int Capacity , int DormitoryGender)
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
}
