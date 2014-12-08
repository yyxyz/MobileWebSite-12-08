using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{

    public partial class CollectionClass
    {

        [Key]
        [Required]
        [DisplayName("�ղط�������")]
        public int CollectionClass_ID { get; set; }

        [Required]
        [DisplayName("��ҵID")]
        public int Enterprise_ID { get; set; }


        [DisplayName("�ϼ�����ID")]
        public Nullable<int> PIDCollectionClass_ID { get; set; }

        [Required]
        [DisplayName("��������")]
        public string CollectionGroup_Name { get; set; }

        public enum CollectionType
        {
            Enterprise,
            Demand
        }

        [Required]
        [DisplayName("�������")]
        public CollectionType CollectionGroup_Class { get; set; }


        //��������
        public ICollection<BusinessZone> BusinessZone { get; set; }
        public Enterprise Enterprise { set; get; }
        public CollectionClass PID { set; get; }


    }
}
