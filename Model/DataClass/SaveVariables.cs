﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicScale2MES
{
    public class SaveVariables
    {
        //Scale variables
        public static String portName { get; set; }
        public static int baudRate { get; set; }
        public static int dataBits { get; set; }
        public static String stopBits { get; set; }
        public static String parityBits { get; set;  }

        //Data Save
        public static String erpCode { get; set; }
        public static String productCode { get; set; }
        public static String materialCode { get; set; }
        public static int dispatchQty { get; set; }
        public static int finishQty { get; set; }
        public static int passQty { get; set; }
        public static String workOrderUUID { get; set; }
        public static int scaleTotalQty { get; set; }
        public static String employeeUUID { get; set; }
        public static int notGoodQty { get; set; }
        public static bool isEmptyAutoCode { get; set; }
        public static bool isAddNG { get; set; }
        
        public static void ResetScaleCon()
        {
            portName = null;
            baudRate = 0;
            dataBits = 0;
            stopBits = null;
            parityBits = null;
        }
        public static void ResetVariables()
        { 
            erpCode = null;
            workOrderUUID = null;
            materialCode = null;
            productCode = null;
            finishQty = 0;
            passQty = 0;
            dispatchQty = 0;
            scaleTotalQty = 0;
            notGoodQty = 0;
            isEmptyAutoCode = false;
            isAddNG = false;
        } 
        public static void ResetEmployee()
        {
            employeeUUID = null;
        }
    }
}
