using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class InfoClass
    {
        //public properties
        public string productID { get; set; }
        public string condition { get; set; }
        public string platform { get; set; }
        public string manufacturer { get; set; }
        public string os { get; set; }
        public string cost { get; set; }
        public string model { get; set; }
        public string memory { get; set; }
        public string cpuType { get; set; }
        public string cpuBrand { get; set; }
        public string lcdSize { get; set; }
        public string cpuNumber { get; set; }
        public string cpuSpeed { get; set; }
        public string hdd { get; set; }
        public string gpuType { get; set; }
        public string webcam { get; set; }
        

        //constructor
        public InfoClass (string product_ID = "", string condition = "", string platform = "", string manufacturer = "", string os ="", string cost="",
            string model="", string memory="", string cpu_type="", string cpu_brand="", string lcd_size="", string cpu_number="", string cpu_speed="",
            string hdd="", string gpu_type="", string webcam="" )
        {
            this.productID = product_ID;
            this.condition = condition;
            this.platform = platform;
            this.manufacturer = manufacturer;
            this.os = os;
            this.cost = cost;
            this.model = model;
            this.memory = memory;
            this.cpuType = cpu_type;
            this.cpuBrand = cpu_brand;
            this.lcdSize = lcd_size;
            this.cpuNumber = cpu_number;
            this.cpuSpeed = cpu_speed;
            this.hdd = hdd;
            this.gpuType = gpu_type;
            this.webcam = webcam;
            
        }

    }
}
