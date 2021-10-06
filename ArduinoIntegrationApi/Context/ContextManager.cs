using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ArduinoIntegrationApi.DataModels;
using Microsoft.EntityFrameworkCore;


namespace ArduinoIntegrationApi.Context
{
    public static class ContextManager
    {
        public static RoomReading GetLatestRoomData(string roomName)
        {
            var allRoomData = GetAllRoomData();

            var latestRoomData = (from roomData in allRoomData
                where roomData.Rd_RoomName == roomName
                orderby roomData.Rd_Cts descending
                select roomData).ToList();

            return latestRoomData.FirstOrDefault();
        }


        private static List<RoomReading> GetAllRoomData()
        {
            ArduinoApiContext ctx = new ArduinoApiContext();
            var allRoomData = ctx.RoomDatas
                .Include(temp => temp.HeadTemperatureReading)
                .Include(temp2 => temp2.FeetTemperatureReading)
                .Include(light => light.LightReading)
                .Include(sound => sound.SoundReading)
                .Include(Humidify => Humidify.HumidityReading)
                .Include(curtain => curtain.CurtainReading)
                .ToList();

            return allRoomData;
        }


        public static bool PostRoomData(string roomName, float tempHead, float humHead, float tempFeet,
            string soundStatus, string curtainStatus, string lightStatus)
        {
            bool newRoomDataAdded = false;

            DateTime dateNow = DateTime.Now;

            //// remove millisecounds
            dateNow = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, dateNow.Hour, dateNow.Minute,
                dateNow.Second, dateNow.Kind);

            using (ArduinoApiContext ctx = new ArduinoApiContext())
            {
                ctx.RoomDatas.Add(new RoomReading()
                {
                    Rd_Cts = dateNow,
                    Rd_RoomName = roomName,
                    HeadTemperatureReading = new TemperatureReading()
                    {
                        Ts_Value = tempHead,
                    },
                    HumidityReading = new HumidityReading()
                    {
                        Hum_Value = humHead
                    },
                    FeetTemperatureReading = new TemperatureReading()
                    {
                        Ts_Value = tempFeet
                    },
                    SoundReading = new SoundReading()
                    {
                        Sr_Value = soundStatus
                    },
                    CurtainReading = new CurtainReading()
                    {
                        Cur_Value = curtainStatus
                    },
                    LightReading = new LightReading()
                    {
                        Ls_Value = lightStatus
                    }
                });
                Thread.Sleep(1000);
                ctx.SaveChanges();
                newRoomDataAdded = true;
            }

            return newRoomDataAdded;
        }
    }
}