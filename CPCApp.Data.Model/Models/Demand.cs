using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public partial class Demand
    {
        [Key]
        [DisplayName("��������")]
        public int Demand_ID { get; set; }

        [Required]
        [DisplayName("��������ҵ����")]
        public int Enterprise_ID { get; set; }

        [Required]
        [DisplayName("��������")]
        public string Demand_Name { get; set; }

        [Required]
        [DisplayName("��������")]
        public string Demand_Description { get; set; }
        [Required]
        [DisplayName("�����û�ID")]
        public int PublisherUser_ID { get; set; }
       
        [Required]
        [DisplayName("�����Ƿ񹫿�")]
        public bool Demand_Public { get; set; }

        [Required]
        [DisplayName("����ʱ��")]
        public DateTime BeginTime { get; set; }

        [Required]
        [DisplayName("����ʱ��")]
        public DateTime EndTime { get; set; }

        [DisplayName("�����ļ���ַ")]
        public string filePath { get; set; }

        [DisplayName("�����ļ������ַ")]
        public string flashpaperPath { get; set; }
        [DisplayName("�������Ƿ�ɾ��")]
        public bool DeleteOrNOt { get; set; }
        public Enterprise Enterprise { get; set; }//��������

       

    }
}
