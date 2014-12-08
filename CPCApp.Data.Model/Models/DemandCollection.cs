using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public partial class DemandCollection
    {
        [Key]
        [DisplayName("�����ղ�����")]
        public int DemandCollection_ID { get; set; }

        
        [Required]
        [DisplayName("��������")]
        public int Demand_ID { get; set; }

        public string Demand_Name { get; set; }

        [DisplayName("�����ղ�����")]
        public string Collection_Description { get; set; }

        [Required]
        [DisplayName("�ղط�������")]
        public int CollectionClass_ID { get; set; }

        public string CollectionGroup_Name { get; set; }

        //��������
        public CollectionClass CollectionClass { get; set; }
        public Demand Demand { get; set; }
    }
}
