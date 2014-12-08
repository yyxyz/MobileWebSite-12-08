using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public partial class DemandClass
    {
        [Key]
        [DisplayName("�����������")]
        public int DemandClass_ID { get; set; }

        [Required]
        [DisplayName("��������")]
        public int Demand_ID { get; set; }
        [Required]
        [DisplayName("�������")]
        public int Class_ID { get; set; }

        //��������
        public Demand Demand { get; set; }
        public Class Class { get; set; }
    }
}
