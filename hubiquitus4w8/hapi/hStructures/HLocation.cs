﻿/*
 * Copyright (c) Novedia Group 2012.
 *
 *     This file is part of Hubiquitus.
 *
 *     Hubiquitus is free software: you can redistribute it and/or modify
 *     it under the terms of the GNU General Public License as published by
 *     the Free Software Foundation, either version 3 of the License, or
 *     (at your option) any later version.
 *
 *     Hubiquitus is distributed in the hope that it will be useful,
 *     but WITHOUT ANY WARRANTY; without even the implied warranty of
 *     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *     GNU General Public License for more details.
 *
 *     You should have received a copy of the GNU General Public License
 *     along with Hubiquitus.  If not, see <http://www.gnu.org/licenses/>.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using log4net;

namespace hubiquitus4w8.hapi.hStructures
{
    /// <summary>
    /// Version 0.5
    /// This structure describe the location
    /// </summary>
    public class HLocation : JObject
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(HLocation));
        public HLocation()
        { 
        }

        public HLocation(JObject jsonObj)
            : base(jsonObj)
        {
        }

        
        //Getters & setters

        /// <summary>
        /// Get the pos. null if undefined
        /// </summary>
        /// <returns></returns>
        public HGeo GetPos()
        {
            HGeo pos = null;
            try
            {
                pos = new HGeo(JObject.Parse(this["pos"].ToString()));
            }
            catch (Exception e)
            {
                log.Error("Can not fetch the pos attribute : ", e);
            }
            return pos;
        }

        /// <summary>
        /// Set the pos.
        /// </summary>
        /// <param name="pos"></param>

        public void SetPos(HGeo pos)
        {
            try
            {
                if (pos == null)
                    log.Error("The pos attribute can not be null!");
                else
                    this["pos"] = pos;
            }
            catch (Exception e)
            {
                log.Error("Can not update the pos attribute: ", e);
            }
        }


        /// <summary>
        /// Get the zip code of the location. NULL if undefined
        /// </summary>
        /// <returns></returns>
        public string GetZip()
        {
            string zip = null;
            try
            {
                zip = this["zip"].ToString();
            }
            catch (Exception e)
            {
                log.Error("Can not fetch the zip attribute : ", e);
            }
            return zip;
        }

        public void SetZip(string zip)
        {
            try
            {
                if (zip == null)
                    this.Remove("zip");
                else
                    this["zip"] = zip;
            }
            catch (Exception e)
            {
                log.Error("Can not update the zip attribute : ", e);
            }
        }

        /// <summary>
        /// Get the way number of the location. NULL if undefined
        /// </summary>
        /// <returns></returns>
        public string GetNum()
        {
            string num = null;
            try
            {
                num = this["num"].ToString();
            }
            catch (Exception e)
            {
                log.Error("Can not fetch the num attribute : ", e);
            }
            return num;
        }

        public void SetNum(string num)
        {
            try
            {
                if (num == null)
                    this.Remove("num");
                else
                    this["num"] = num;
            }
            catch (Exception e)
            {
                log.Error("Can not update the num attribute : ", e);
            }
        }

        /// <summary>
        /// Get the type of the way of the location. NULL if undefined
        /// </summary>
        /// <returns></returns>
        public string GetWaytype()
        {
            string waytype = null;
            try
            {
                waytype = this["waytype"].ToString();
            }
            catch (Exception e)
            {
                log.Error("Can not fetch the waytype attribute : ", e);
            }
            return waytype;
        }

        public void SetWaytype(string waytype)
        {
            try
            {
                if (waytype == null)
                    this.Remove("waytype");
                else
                    this["waytype"] = waytype;
            }
            catch (Exception e)
            {
                log.Error("Can not update the waytype attribute : ", e);
            }
        }

        /// <summary>
        /// Get the name of the street/way of the location. NULL if undefined
        /// </summary>
        /// <returns></returns>
        public string GetWay()
        {
            string way = null;
            try
            {
                way = this["way"].ToString();
            }
            catch (Exception e)
            {
                log.Error("Can not fetch the way attribute : ", e);
            }
            return way;
        }

        public void SetWay(string way)
        {
            try
            {
                if (way == null)
                    this.Remove("way");
                else
                    this["way"] = way;
            }
            catch (Exception e)
            {
                log.Error("Can not update the way attribute : ", e);
            }
        }

        /// <summary>
        /// Get the address complement of the location. NULL if undefined.
        /// </summary>
        /// <returns></returns>
        public string GetAddr()
        {
            string addr = null;
            try
            {
                addr = this["addr"].ToString();
            }
            catch (Exception e)
            {
                log.Error("Can not fetch the addr attribute : ", e);
            }
            return addr;
        }

        public void SetAddr(string addr)
        {
            try
            {
                if (addr == null)
                    this.Remove("addr");
                else
                    this["addr"] = addr;
            }
            catch (Exception e)
            {
                log.Error("Can not update the addr attribute : ", e);
            }
        }

        /// <summary>
        /// Get the floor number of the location. NULL if undefined.
        /// </summary>
        /// <returns></returns>
        public string GetFloor()
        {
            string floor = null;
            try
            {
                floor = this["floor"].ToString();
            }
            catch (Exception e)
            {
                log.Error("Can not fetch the floor attribute : ", e);
            }
            return floor;
        }

        public void SetFloor(string floor)
        {
            try
            {
                if (floor == null)
                    this.Remove("floor");
                else
                    this["floor"] = floor;
            }
            catch (Exception e)
            {
                log.Error("Can not update the floor the floor attribute : ", e);
            }
        }

        /// <summary>
        /// Get the building’s identifier of the location. NULL if undefined.
        /// </summary>
        /// <returns></returns>
        public string GetBuilding()
        {
            string building = null;
            try
            {
                building = this["building"].ToString() ;
            }
            catch (Exception e)
            {
                log.Error("Can not fetch the building attribute : ", e);
            }
            return building;
        }

        public void SetBuilding(string building)
        {
            try
            {
                if (building == null)
                    this.Remove("building");
                else
                    this["building"] = building;
            }
            catch (Exception e)
            {
                log.Error("Can not update the building attribute : ", e);
            }
        }

        /// <summary>
        /// Get city of the location. NULL if undefined
        /// </summary>
        /// <returns></returns>
        public string GetCity()
        {
            string city = null;
            try
            {
                city = this["city"].ToString();
            }
            catch (Exception e)
            {
                log.Error("Can not update the city attribute : ", e);
            }
            return city;
        }

        public void SetCity(string city)
        {
            try
            {
                if (city == null)
                    this.Remove("city");
                else
                    this["city"] = city;
            }
            catch (Exception e)
            {
                log.Error("Can not update the city attribute : ", e);
            }
        }

        /// <summary>
        /// Get countryCode of the location. NULL if undefined.
        /// </summary>
        /// <returns></returns>
        public string GetCountryCode()
        {
            string countryCode = null;
            try
            {
                countryCode = this["countryCode"].ToString();
            }
            catch (Exception e)
            {
                log.Error("Can not fetch the countryCode attribute : ", e);
            }
            return countryCode;
        }

        public void SetCountryCode(string countryCode)
        {
            try
            {
                if (countryCode == null)
                    this.Remove("countryCode");
                else
                    this["countryCode"] = countryCode;
            }
            catch (Exception e)
            {
                log.Error("Can not update the countyCode attribute : ", e);
            }
        }
    }
}
