using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;

namespace ProjectAPI.Data
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<LogEntry>().HasData(

                new LogEntry()

                {
                    LogEntryId = 1,
                    WalkedThroughDoor = new DateTime (2021, 11, 2, 4, 45, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    LogEntryId = 2,
                    WalkedThroughDoor = new DateTime (2021, 11, 2, 4, 46, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    LogEntryId = 3,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 4, 47, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    LogEntryId = 4,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 4, 48, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    LogEntryId = 5,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 6, 37, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    LogEntryId = 6,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 6, 38, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    LogEntryId = 7,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 6, 39, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    LogEntryId = 8,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 6, 40, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    LogEntryId = 9,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 6, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    LogEntryId = 10,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 6, 46, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    LogEntryId = 11,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 6, 49, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    LogEntryId = 12,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 6, 50, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    LogEntryId = 13,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 7, 3, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    LogEntryId = 14,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 7, 4, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    LogEntryId = 15,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 10, 15, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    LogEntryId = 16,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 10, 16, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    LogEntryId = 17,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 10, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0201B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    LogEntryId = 18,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 10, 27, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0201B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    LogEntryId = 19,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 10, 28, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    LogEntryId = 20,
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 10,35, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 10,36, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 10,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 11, 6, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 11,7, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0201B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 11,15, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 11,16, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 11, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 11, 18, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 11,19, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 11,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 11,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 11,40, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 12,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 12,54, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 12,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 12,57, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 12,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 12,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 12,60, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,13,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,13, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,13,40, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,13,52, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,13,53, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,13,57, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,13,58, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,15,33, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,15,34, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,15,36, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,15,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,15,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,15,59, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,15,60, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 17,9, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 17, 10, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 17,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 17,26, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 17,30, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 17,31, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 17,52, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 17,53, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 18,26, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 18,27, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 18,38, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 18,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 18,39, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 18,40, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 18,48, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 18,49, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 18,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 18,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 18,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2, 18,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,19,9, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,19, 10, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,19, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,19, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,19,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,19,48, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,20, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,20, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,21,1, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,21, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,21, 4, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,21,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,21,13, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,21,14, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,21, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,21,46, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,21,48, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,21,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,21,60, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,23,27, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,23,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,23,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 2,23,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 6,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 6,8, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,7,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,7,14, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,7,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,7,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,9,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,9,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 10,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 10, 4, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 10,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 10, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 10,9, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 10,10, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 10, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 10, 12, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 10,36, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 10,37, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 10,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 10,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 10,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 10,54, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 10,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 11,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 11, 4, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 11,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 11,14, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 11,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 11,26, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 11,35, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 11,35, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 11,36, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 11,41, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 11,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 11,49, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 11,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 11,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 11,54, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 12,1, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 12, 2, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 12,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 12,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 12, 10, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 12, 11, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 12,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 12,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 12,44, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,13,3, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,13, 4, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,13,35, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,13,36, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,13,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,13,38, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,13,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,13,40, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,13,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,13,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,13,57, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,13,58, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,13,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,13,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,13,59, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,14,0, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,14, 4, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,14,5, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,14,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,14,32, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,14,33, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0302C",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,14,44, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0302C",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,14, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,14, 45, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,14,46, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,14,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,14,48, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,14,49, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,14,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,14,57, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,14,58, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,14,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,15,0, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,15, 11, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,15, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,15,14, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,15,28, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,15,29, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0302C",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,16, 11, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,16, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,16,40, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,16,41, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,16,53, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,16,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,16,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,16,56, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 17,36, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 17,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 17,48, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 17,49, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 18,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 18,14, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 18,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7, 18,32, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,19,24, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,19,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,19,41, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,19,42, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,20,41, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,20,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,21,5, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,21, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,21, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,21, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,21,27, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,21,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,21,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,7,21,48, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,1,51, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,1,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 2,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 2,43, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,5,49, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,5,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 6,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 6,40, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,7,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,7, 4, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,9,1, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,9, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,9,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,9, 4, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,9,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,9,14, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,9,15, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,9,16, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,9,30, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,9,31, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,9, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,9,46, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,9,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,9,48, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 10, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 10, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 10,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 10,14, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 10,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 10,26, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 10,43, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 10,44, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 11,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 11,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 11,21, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 11,22, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 11,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 11,32, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 11,33, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 11,34, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12, 4, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12,5, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12,21, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12,22, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12,23, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0202B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12,33, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0202B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12,34, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12,35, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12,36, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0302A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12,39, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12,40, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12,48, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0302A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12,49, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12,56, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12,57, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12,57, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 12,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,13, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,13, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,13,7, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,13,9, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,13, 10, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0202B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,13,19, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,13,27, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,13,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0302A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,15,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,15, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,15,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,15,8, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,16,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,16,52, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 17, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 17, 12, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 18,21, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 18,22, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 18,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 18,48, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 18,57, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 18,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 18,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9, 18,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,19,0, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,19,0, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,19,19, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,19,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,19,21, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,19,22, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,19,22, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,19,23, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,19,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,19,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,19,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,19,56, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,20,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,20, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,20,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,20,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,20,9, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,20, 10, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,20,24, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,20,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,21,37, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,21,38, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,21,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,21,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,21,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,21,54, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,23,27, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,9,23,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,1,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,1,51, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,7,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,7,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,7,32, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,8,27, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,8,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,8,35, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,8,36, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,9,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,9,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,9,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,9,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,10, 4, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,10,5, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,10, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,10, 18, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,10,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,10,56, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 11,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 11, 4, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 11,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 11,14, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 11,15, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 11,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 11,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 11,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 11,32, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 11,49, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 11,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 11,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 12,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 12,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 12,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 12,40, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 12, 45, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 12,46, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 12,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 12,48, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 12,49, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 12,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 12,56, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 12,57, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,13,7, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,13,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,13,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,13,40, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,13,57, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,13,58, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,13,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,13,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0302B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,0, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0302B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14, 18, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,23, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,24, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,26, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,32, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,33, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,34, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,38, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,46, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,46, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,47, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,48, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,50, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,14,51, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0302B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,15, 4, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,15,5, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,15,21, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,15,22, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,15,33, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,15,33, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,15,34, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,15,34, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,15,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,15,38, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,15,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,15, 45, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,15,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,15,51, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,16,15, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,16,16, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,16,35, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,16,36, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 17,30, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 17,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 17, 45, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 17,46, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 17,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 17,48, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 18,15, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 18,16, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 18,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 18,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 18,46, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10, 18,47, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19, 4, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,23, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,24, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,27, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,36, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,40, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,53, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,19,56, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,20, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,20,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,20, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,20, 12, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,20,14, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,20,15, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,20,24, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,20,25, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,20,31, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,20,32, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,20,33, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,20,34, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,20,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,20,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,20,49, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 10,20,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 6,27, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 6,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,7,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,7,56, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,8,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,8,48, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,9, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,9, 18, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,9,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,9,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,9,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,9,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,9,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,9,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 10,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 10, 4, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 10, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 10, 18, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 10,32, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 10,33, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 10,39, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 10,40, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 10, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 10,46, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 10,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 11,0, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 11,9, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 11, 10, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 11,15, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 11,16, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 11,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 11,31, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 11,32, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 11,33, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 12,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 12,8, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 12, 17, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 12, 18, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 12,23, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 12,24, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 12,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 12,26, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 12,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 12,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,13,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,13,14, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,13,46, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,13,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,13,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,13,53, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,13,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,13,54, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,13,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0302D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0302D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,15, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,16, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14, 18, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,20, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,21, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0201C",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,33, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,33, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0201C",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,34, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,34, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,36, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,40, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,46, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,47, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0302D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,48, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,49, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,14,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,15,0, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,15,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,15,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,15,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0201C",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,15,42, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,15,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,15,56, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,15,57, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,16,15, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,16,16, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,16,27, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,16,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,16,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,16,48, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 17,34, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 17,35, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 17,51, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 17,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 18,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 18, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 18,28, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11, 18,29, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,19,20, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,19,21, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,19,32, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,19,33, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,19,41, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,19,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,19,49, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,19,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,21,23, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,11,21,24, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 2,35, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 2,36, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 6,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 6,38, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,7,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,7, 4, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,8, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,8, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,8,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,8,52, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,9,49, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,9,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 10,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,0, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,5, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11, 6, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,14, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,15, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,26, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,46, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,48, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,56, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,12,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,12,42, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,12,57, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,12,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,13,57, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,13,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,13,59, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,0, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,20, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,21, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,26, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,32, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,54, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,1, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15, 4, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,14, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,21, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,22, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,35, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,36, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0301B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,52, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0301B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,53, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,16,5, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,16, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,16,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,16,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,16,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,16,35, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,16,36, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0301B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 18,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 18,40, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19, 17, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19, 18, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,20, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,21, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,22, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,46, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20, 18, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,35, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,36, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,42, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20, 45, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,49, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,51, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,21,1, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,21, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,3,55, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,3,56, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,3,57, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,3,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,7,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,7,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,7,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,7,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,7,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,7,56, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,7,57, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,7,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,8,57, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,8,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 11,33, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 11,34, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 12,9, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 12, 10, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 12, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0202A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 12, 18, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0202A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 12,19, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 12,53, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 12,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,13,0, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,13,1, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,13, 2, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,13,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,13, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0202A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,13,23, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,13,24, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,13,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,13,26, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,13,48, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,13,49, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,13,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,14,0, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,14, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,14, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,14,14, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,14,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,14,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,14,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,14,40, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,14,55, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,14,56, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,15,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,15,14, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,15,15, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0301B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,15,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0301B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,15,26, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,15,35, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,15,36, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,15,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,15,38, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,15,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,16,1, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,16, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,16,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,16, 4, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,16, 10, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,16, 11, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0301B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,16,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,16,14, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,16,36, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,16,37, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 17,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 17,32, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 17,33, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 17,34, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 17,35, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 17,36, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 17,46, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 17,47, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 17,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 17,51, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 17,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 17,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 18,0, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 18,1, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 18,21, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 18,22, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 18,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 18,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 18,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 18,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 18,54, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13, 18,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19,3, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19, 18, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19,20, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19,21, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19,21, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19,22, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19,29, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19,46, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19,46, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,19,47, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,20,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,20,14, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,20,25, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,20,26, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,20,28, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,20,35, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,20,36, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,20,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,13,20,55, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 4,9, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 4, 10, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 4, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 4, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 4,19, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 4,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 6, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 6, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 6,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 6,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,7,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,7,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,7,22, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,8,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,8,32, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,9,1, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,9, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,9,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,9, 4, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,9,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,9,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,9,27, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,9,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,9,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 10,0, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 10,9, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 10,10, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 10,16, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 10, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 10, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 10, 18, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 10,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 10,20, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 10,24, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 10,25, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 10,36, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 10,37, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 10,38, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 10,39, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 11,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 11,14, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 11,21, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 11,22, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 11,23, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 11,24, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 11,33, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 11,33, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 11,33, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 11,34, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 11,34, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 11,34, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,13,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,13,32, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,14,9, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,14, 10, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,14, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0102A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,14,24, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0102A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,14,25, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,14,25, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,14,26, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,14,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,14,56, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,14,57, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,14,58, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,14,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,14,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,14,60, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,15,1, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,15, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,15,9, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,15, 10, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0102A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,15, 11, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,15, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,15,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,15,14, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,15,15, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0103A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,15,30, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0103A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,15,31, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,15,32, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,15,33, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,15,35, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,15,36, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,16,00, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,16,14, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,16,15, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0103A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,16,28, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,16,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,16,33, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,16,34, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,16,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,16, 45, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,16,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 17, 4, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 17,5, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 17,49, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 17,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 17,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 17,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 17,58, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 17,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 18,5, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 18, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 18,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14, 18,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,19, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,19,7, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,19,8, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,19,9, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,19,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,19,14, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,19,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,19,29, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,19,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,19,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,19,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,19,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,19,46, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,20,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,20,48, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,21,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,21,14, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,21,16, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,21,23, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,21,24, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,23,53, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,23,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,23,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,14,23,56, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,0,7, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,0,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,0,9, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,0, 10, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,0,47, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,0,48, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,1, 11, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,1, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 6, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 6, 12, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,7,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,7, 6, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,7,27, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,7,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,7,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,7,40, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,7,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,7,48, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,8,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,8,08, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,8,15, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,8,16, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,9,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,9,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,9,32, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,9,33, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,9,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,9,40, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,9,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,9,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,9,58, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,9,59, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 10,1, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 10, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 10,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 10,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 10,21, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 10,22, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 10,33, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 10,34, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 10,49, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 10,50, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 10,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 10,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 11,49, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 11,50, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 11,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0103B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 12,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0103B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 12, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 12, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 12, 18, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 12,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 12,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 12,41, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 12,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 12,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0103B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,13,19, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,13,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,13,27, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,13,28, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,13,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,13,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,13,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,13,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,14,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,14,38, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,14,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0103A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,14,46, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,14,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,14,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0103A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,14,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,14,59, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,15,0, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,15,1, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,15, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,15,21, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,15,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,15,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0103A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,16,15, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,16,16, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,16,57, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,16,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 17,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 17,9, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 17,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 17,14, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 17,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 17,26, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 17,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 17,38, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 17,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 17,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 17,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 17,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 18,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 18,32, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 18,39, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15, 18,40, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,19,41, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,19,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,19,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,19,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,20,49, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,20,50, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,21,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,21,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,15,21,32, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 2,22, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 2,23, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,3,37, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,3,38, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 6,23, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 6,24, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,7,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,7, 4, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,7, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,7, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,8,21, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,8,22, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,8,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,8,54, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 10, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 10, 18, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 10,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 10,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 10,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 10,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 10,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 10,32, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 10,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 10,54, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 11,15, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 11,16, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 11, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0101A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 11,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0101A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 11,32, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 11,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 11,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 11,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 11,56, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 12,1, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 12,9, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 12, 10, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 12, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 12,12, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 12,16, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 12, 17, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0101A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 12,27, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 12,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 12,44, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 12, 45, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 12,57, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 12,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,13, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,13, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,13,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,13,40, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,13,57, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,13,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,14,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,14,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,14, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,14, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,14,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,14,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,14,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,14,32, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,14,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,14,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,15,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,15,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,15,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,15,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,15, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,15,46, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,15,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,15,48, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,15,49, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,15,55, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,15,56, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,15,57, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,15,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,16, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,16, 18, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,16,27, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,16,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,16,38, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 17, 11, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 17, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 18, 17, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16, 18,18, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,19,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,19, 4, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,19,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,19,26, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,19,27, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,19,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,19,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,19,32, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,19,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,19,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,20,22, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,20,23, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,20,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,20,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,20,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,20,40, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,20, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,20, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,20,46, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,20,46, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,20,57, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,16,20,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,0,3, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,0, 4, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 6,9, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 6, 10, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 6,21, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 6,22, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 6,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 6,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,7,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,7,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,7, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,7,46, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,7,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,7,56, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,8,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,8,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,8,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,8,52, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,9,53, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,9,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,9,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,9,56, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 10,53, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 10,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,13,9, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,13, 10, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,13, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0103B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,13,23, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0103B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,13,24, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,13,27, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,13,28, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,13,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0302D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,13,40, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0302D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,13,41, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,13,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,14,1, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,14, 2, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,14, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,14,3, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0103B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,14,14, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,14,24, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,14,25, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0302D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,14,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,15,0, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,16,15, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,16,16, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,16,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,16,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,16,32, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,16,34, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,16,35, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,16,49, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,16,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,17, 6, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,17,7, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,17,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,17,30, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,17,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,17,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,17,33, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,17,34, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,17,46, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,17,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,17,52, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,17,53, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,17,58, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,17,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18, 10, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18, 11, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,19, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,21, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,22, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,23, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,24, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,26, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,32, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,42, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,48, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,49, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,50, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,51, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,52, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17, 18,53, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,19,1, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,19, 2, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,19, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,19,3, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,19,44, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,19, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,19,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,19,53, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,19,58, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,19,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,20,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,20,9, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,20, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,23,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,23,31, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,23,32, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 17,23,33, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 6,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 6,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 6,8, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 6,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 6, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 6, 12, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 6,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 6,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,7,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,7,26, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,7,47, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,7,48, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,8,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,8,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 10,9, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 10,10, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 11,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 11,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 12,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 12,8, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 12,9, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 12,9, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0103A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 12, 10, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 12,21, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0103A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 12,22, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 12,32, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 12,33, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 12,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 12,42, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 12,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 12,50, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 12,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 12,51, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,13,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,13, 4, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0103A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,13,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,13,14, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,13,20, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,13,21, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,13,26, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,13,40, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,13,41, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,13,41, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,13,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,13,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,13,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,14,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,14,38, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,14,51, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,14,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,14,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,14,54, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,15,9, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,15, 10, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,15,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,15,48, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,15,57, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,15,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,16,14, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,16,15, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 17,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 17, 4, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 17,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 17, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 17,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 17,8, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 17,9, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 17, 10, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 17,25, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 17,26, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 17,27, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 17,27, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 17,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18, 17,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,18,9, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,18, 10, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,18, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,18, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,18,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,18,38, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,18,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,18,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,18, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,18,46, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,19,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,19,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,19, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,19,46, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,20,49, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 18,20,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 2,27, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 2,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,7,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,7, 4, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,7,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,7,40, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,7,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,8,0, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,8,27, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,8,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,9,1, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,9, 2, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,9,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,9,14, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 10,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 10,32, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 10,33, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0102B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 10,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0102B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 10,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 10,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 10,44, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 10, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0302A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 10,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0302A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 10,56, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 11,11, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 11,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 11,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0102B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 11,21, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 11,22, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 11,23, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 11,24, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 11,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 11,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 11,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0302A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 12,7, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 12,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,13,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,13,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,14, 2, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,14,3, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,14,15, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,14,16, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,14,31, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,14,32, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,14,35, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,14,36, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,14,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,14,38, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,14,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,14,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,14,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,14,56, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,15,16, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,15, 17, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,15,23, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,15,24, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,15,49, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,15,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 17,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 17,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 18,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 18, 4, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 18,15, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 18,16, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 18,35, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19, 18,36, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,20, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,20, 12, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,20,27, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,20,28, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,20,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,20,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,20,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,20,52, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,22,39, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,22,40, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,23,57, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,19,23,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,0,29, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,0,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 6,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 6,38, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,7,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,7,42, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,7,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,7,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,7,46, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,8,15, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,8,16, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 10,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 10,14, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 11,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 11,8, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 11,9, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 11, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 11, 18, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 11,39, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 11,40, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 11,47, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 11,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 11,54, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 11,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 11,58, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 11,59, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12,1, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12,23, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12,24, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12,26, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12,26, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12,27, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12,31, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12,32, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12,33, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12,34, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12,57, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0301D",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 12,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,13,0, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,13,15, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,13,16, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,13,23, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,13,23, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,13,24, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,13,24, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,13,55, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,13,56, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,14, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,14, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,14, 18, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,14, 18, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,14,31, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,14,32, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,15,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,15,26, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,15,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,15,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,15,35, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,15,36, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,15,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,15,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 17, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 17, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 17,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 17,32, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 17,32, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 17,33, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 17,57, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 17,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 18,23, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 18,24, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 18,31, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 18,32, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 18,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 18,38, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 18,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 18,40, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 18,41, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 18,42, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 18,44, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21, 18, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,19, 4, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,19,5, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,19,23, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,19,24, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,20,1, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,20,1, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,20, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,20, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,23, 45, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11,21,23,46, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 2,35, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 2,36, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 6,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 6,38, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202A",
                    FirstName = "Lucas",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,7,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,7, 4, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,8, 11, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,8, 12, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301D",
                    FirstName = "Maja",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,8,51, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,8,52, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,9,49, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,9,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302D",
                    FirstName = "Oscar",
                    LastName = "Chen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 10,59, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,0, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,5, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103A",
                    FirstName = "Alicia",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11, 6, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,14, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,15, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,26, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,46, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,47, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,48, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,55, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 11,56, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0201A",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,12,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,12,42, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,12,57, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,12,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301A",
                    FirstName = "Ella",
                    LastName = "Ahlström"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,13,57, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,13,58, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,13,59, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,0, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302A",
                    FirstName = "Noah",
                    LastName = "Almgren"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,5, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,7, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,8, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201B",
                    FirstName = "William",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,20, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,21, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,25, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,26, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,32, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,53, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,14,54, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,1, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "SOPOR",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,3, 0),
                    CodeString = "DÖIN",
                    DoorName = "SOPOR",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15, 4, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,13, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,14, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,21, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,22, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301C",
                    FirstName = "Elsa Ahlström",
                    LastName = ""
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,35, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,36, 0),
                    CodeString = "FDUT",
                    DoorName = "VAKT",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,37, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0301B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,52, 0),
                    CodeString = "DÖIN",
                    DoorName = "VAKT",
                    TagNumber = "0301B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,15,53, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,16,5, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,16, 6, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0202",
                    TagNumber = "0202B",
                    FirstName = "Ebba",
                    LastName = "Adolfsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,16,28, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,16,29, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,16,30, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Alma",
                    LastName = "Alfredsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,16,35, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0301",
                    TagNumber = "0301B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,16,36, 0),
                    CodeString = "DÖUT",
                    DoorName = "VAKT",
                    TagNumber = "0301B",
                    FirstName = "Vaktmästare",
                    LastName = "Vaktson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 18,39, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12, 18,40, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201D",
                    FirstName = "Astrid",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19, 17, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19, 18, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0101",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,19, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,20, 0),
                    CodeString = "DÖIN",
                    DoorName = "UT",
                    TagNumber = "0101A",
                    FirstName = "Liam",
                    LastName = "Jönsson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,20, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,21, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,22, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,42, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201A",
                    FirstName = "Olivia",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19, 45, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,19,46, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20, 17, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20, 18, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0103",
                    TagNumber = "0103B",
                    FirstName = "Aaron",
                    LastName = "Sanchez"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,35, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,36, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,41, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,42, 0),
                    CodeString = "DÖIN",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,43, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102A",
                    FirstName = "Elias",
                    LastName = "Petterson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,44, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20, 45, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302C",
                    FirstName = "Kattis",
                    LastName = "Backman"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,49, 0),
                    CodeString = "DÖIN",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0302",
                    TagNumber = "0302B",
                    FirstName = "Adam",
                    LastName = "Andersen"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,50, 0),
                    CodeString = "DÖUT",
                    DoorName = "TVÄTT",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,20,51, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0201",
                    TagNumber = "0201C",
                    FirstName = "Alexander",
                    LastName = "Erlander"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,21,1, 0),
                    CodeString = "DÖUT",
                    DoorName = "UT",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }, new LogEntry()
                {
                    WalkedThroughDoor = new DateTime(2021, 11, 12,21, 2, 0),
                    CodeString = "DÖUT",
                    DoorName = "LGH0102",
                    TagNumber = "0102B",
                    FirstName = "Wilma",
                    LastName = "Johansson"
                }

                );

        }
    }
}
