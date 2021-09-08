using System;
using System.Collections.Generic;
using System.Linq;
using ArduinoIntegrationApi.DataModels;
using ArduinoIntegrationApi.Enums;

namespace ArduinoIntegrationApi.Context
{
    public static class ContextManager
    {
        

        public static bool RoomExists(string roomName)
        {
            using ( ArduinoApiContext Ctx = new ArduinoApiContext())
            {
                var Rooms = (from r in Ctx.Rooms
                    where r.RoomName == roomName
                    select r).ToList();
                if (Rooms.Count > 0)
                {
                    return true;
                }

                return false;
            }
        }

        public static Room CreateNewRoom(string roomName)
        {
            Room newRoom = new Room();
            if (!RoomExists(roomName))
            {
                using (ArduinoApiContext Ctx = new ArduinoApiContext())
                {
                    newRoom.RoomName = roomName;

                    Ctx.Rooms.Add(newRoom);
                    Ctx.SaveChanges();
                }
            }

            return newRoom;
        }

        public static List<Room> GetAllRooms()
        {
            ArduinoApiContext Ctx = new ArduinoApiContext();

            var rooms = (from r in Ctx.Rooms
                select r).ToList();

            return rooms;
        }

        public static bool AddNewTemperature(string roomName, float temperatureReading)
        {
            if (RoomExists(roomName))
            {
                using (ArduinoApiContext Ctx = new ArduinoApiContext())
                {
                    Ctx.TemperatureSensors.Add(new TemperatureSensor
                        {
                            T_Value = temperatureReading,
                            T_Cts = DateTime.Now,
                            ComponentType = ComponentType.TemperatureSensor,
                            RoomName = roomName
                        }
                    );

                    Ctx.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        public static bool AddNewLightSensorSate(string roomName, bool lightSensorState)
        {
            if (RoomExists(roomName))
            {
                using (ArduinoApiContext Ctx = new ArduinoApiContext())
                {
                    Ctx.LightSensors.Add(new LightSensor
                        {
                            L_Value = lightSensorState,
                            L_Cts = DateTime.Now,
                            RoomName = roomName,
                            ComponentType = ComponentType.LightSensor
                        }
                    );

                    Ctx.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        public static bool AddNewWindowLockState(string roomName, bool windowLockState)
        {
            if (RoomExists(roomName))
            {
                using (ArduinoApiContext Ctx = new ArduinoApiContext())
                {
                    Ctx.WindowLocks.Add(new WindowLock
                        {
                            W_Value = windowLockState,
                            W_Cts = DateTime.Now,
                            ComponentType = ComponentType.WindowLock,
                            RoomName = roomName,
                        }
                    );

                    Ctx.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        public static TemperatureSensor GetLatestTemperature(string roomName)
        {
            ArduinoApiContext Ctx = new ArduinoApiContext();

            var temperature = from t in Ctx.TemperatureSensors
                where t.RoomName == roomName
                orderby t.T_Cts descending
                select t;

            return temperature.First();
        }

        public static LightSensor GetLatestLightSensorState(string roomName)
        {

            ArduinoApiContext Ctx = new ArduinoApiContext();

            var lightSensorState = from l in Ctx.LightSensors
                where l.RoomName == roomName
                orderby l.L_Cts descending
                select l;

            return lightSensorState.First();
        }

        public static WindowLock GetLatestWindowLockState(string roomName)
        {

            ArduinoApiContext Ctx = new ArduinoApiContext();

            var windowLockState = from w in Ctx.WindowLocks
                where w.RoomName == roomName
                orderby w.W_Cts descending
                select w;

            return windowLockState.First();
        }
    }
}