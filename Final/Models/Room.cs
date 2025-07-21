using System;
using System.Collections.Generic;

namespace Final.Models;

public partial class Room
{
    public long Id { get; set; }

    public int FloorNumber { get; set; }

    public long BlockId { get; set; }

    public int Number { get; set; }

    public int Capacity { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeletedBy { get; set; }

    public DateTime? DeletedOn { get; set; }

    public long CreatBy { get; set; }
    public long ModifiedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }


    public DateTime CreatOn { get; set; }

    public virtual Block Block { get; set; } = null!;

    public virtual User CreatByNavigation { get; set; } = null!;

    public virtual ICollection<RoomAssigment> RoomAssigments { get; set; } = new List<RoomAssigment>();

    public virtual ICollection<TransferRoomAssetHistory> TransferRoomAssetHistories { get; set; } = new List<TransferRoomAssetHistory>();
    public static void SetRoom( int FloorNumber, int Number, int Capacity, long BlockId, long UserId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        Room room = new Room();
        room.FloorNumber = FloorNumber;
        room.Number = Number;
        room.Capacity = Capacity;
        room.BlockId = BlockId;
        room.CreatBy = UserId;
        room.CreatOn = DateTime.Now;

        db.Rooms.Add(room);
        db.SaveChanges();
    }
    public static void EditRoom(int FloorNumber, int Number, int Capacity, long UserId,long EditRoomId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        Room room = Room.FindRoomById(EditRoomId);
        db.Rooms.Update(room);        
        room.FloorNumber = FloorNumber;
        room.Number = Number;
        room.Capacity = Capacity;
        room.ModifiedBy = UserId;
        room.ModifiedOn = DateTime.Now;


        db.SaveChanges();
    }


    public static int StudentCount(long RoomId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        int count = 0;
        foreach (var i in db.RoomAssigments.ToList())
        {
            if (i.RoomId == RoomId) count++;
        }
        return count;
    }
    public static long FindBlockId(long RoomId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        return db.Rooms.Where(i => i.Id == RoomId).FirstOrDefault().BlockId;
    }
    public static Room FindRoomById(long RoomId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        return db.Rooms.Where(i => i.Id == RoomId).FirstOrDefault();
    }
    public static List<Room>? FindByBlockId(long BlockId)
    {
        using DormitoryDbContext db = new DormitoryDbContext();
        return db.Rooms.Where(i => i.BlockId == BlockId).ToList();
    }
}
