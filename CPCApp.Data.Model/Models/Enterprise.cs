using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public partial class Enterprise
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("��ҵ������")]
        public int Enterprise_ID { get; set; }

        [Required]
        [DisplayName("��ҵ����")]
        public string Enterprise_Name { get; set; }

        [DisplayName("��ҵ��־ͼ��")]
        public byte[] Enterprise_Logo { get; set; }


        [DisplayName("��ҵ��ģ")]
        public int Enterprise_Scale { get; set; }


        [DisplayName("��ҵ����ʡ��")]
        public string Enterprise_Province { get; set; }


        [DisplayName("��ҵ���ڳ���")]
        public string Enterprise_City { get; set; }


        [DisplayName("��ҵ��ַ")]
        public string Enterprise_Addr { get; set; }


        [DisplayName("�ʱ�")]
        public string Enterprise_ZipCode { get; set; }


        [Phone]
        [DisplayName("��ҵ�绰 ")]
        public string Enterprise_Tel { get; set; }

        
        [EmailAddress]
        [DisplayName("��ҵ����")]
        public string Enterprise_Email { get; set; }

        [DisplayName("��ҵ����ʱ��")]
        public Nullable<System.DateTime> Enterprise_Create_Time { get; set; }

        [DisplayName("��ҵ����")]
        public string Enterprise_Description { get; set; }

      /*  //��������

        public ICollection<ChatRecord> ChatRecords { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Bid> Bids { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Demand> Demands { get; set; }
        public ICollection<CollectionClass> CollectionClasses { get; set; }
        public ICollection<Case> Cases { get; set; }
        public ICollection<Equipment> Equipments { get; set; }
        public ICollection<BusinessZone> BusinessZones { get; set; }
        public ICollection<EnterpriseClass> EnterpriseClasses { get; set; }
        public ICollection<Directional_Release> Directional_Release { get; set; }*/



    }
}
