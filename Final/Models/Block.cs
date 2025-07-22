using System;
using System.Collections.Generic;

namespace Final.Models;

public partial class Block
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public int FloorNumber { get; set; }

    public int RoomNumber { get; set; }

    public int Capacity { get; set; }

    public long DermitoryId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeletedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public long CreatBy { get; set; }

    public DateTime CreatOn { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual User CreatByNavigation { get; set; } = null!;

    public virtual Dormitory Dermitory { get; set; } = null!;

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
    public static void SetBlock(string Name, int FloorNumber,int RoomNumber,int Capacity, long DormitoryId,long UserId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        Block block = new Block();
        block.Name = Name;
        block.FloorNumber = FloorNumber;
        block.RoomNumber = RoomNumber;
        block.Capacity = Capacity;
        block.DermitoryId = DormitoryId;
        block.CreatBy = UserId;
        block.CreatOn = DateTime.Now;

        db.Blocks.Add(block);
        db.SaveChanges();
    }
    public static void EditBlock(string Name, int FloorNumber, int RoomNumber, int Capacity, long UserId,long EditBlockId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        Block block = Block.FindBlockById(EditBlockId);
        db.Blocks.Update(block);
        block.Name = Name;
        block.FloorNumber = FloorNumber;
        block.RoomNumber = RoomNumber;
        block.Capacity = Capacity;
        block.ModifiedBy = UserId;
        block.ModifiedOn = DateTime.Now;


        db.SaveChanges();
    }
    public static bool AnyBlock(string BlockName)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        bool answer = db.Blocks.Any(i => i.Name == BlockName);
        if (!answer) return answer;
        else
        {
            var Block = db.Blocks.Where(i => i.Name == BlockName).FirstOrDefault();
            if (Block.IsDeleted == false) return true;
            else return false;
        }
    }
    public static string? FindBlockOwnerName(long BlockId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        var USER = db.Roles.Where(i => i.BlockId == BlockId).FirstOrDefault();
        User? _user = null;
        if (USER != null)
        {
            _user = User.FindUserById(USER.UserId);
        }
        if (_user == null) return "";
        else return User.GetFullName(_user);
    }
    public static Block? FindBlockById(long BlockId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        return db.Blocks.Where(i => i.Id == BlockId).FirstOrDefault();
    }
    public static List<Block>? FindByDormitoryId(long DormitoryId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        return db.Blocks.Where(i => i.DermitoryId == DormitoryId).ToList();
    }
    public static void DeleteBlock(long UserDeletedId, long BlockId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        Models.Block Block = Models.Block.FindBlockById(BlockId);
        db.Blocks.Update(Block);
        Block.IsDeleted = true;
        Block.DeletedBy = UserDeletedId;
        Block.DeletedOn = DateTime.Now;
        db.SaveChanges();
    }

}
