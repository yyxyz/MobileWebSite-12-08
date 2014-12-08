using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public partial class BusinessZone
    {
        [Key]
        [DisplayName("��ҵ��Ȧ����")]
        public int BusinessZone_ID { get; set; }

        [Required]
        [DisplayName("�ղط�������")]
        public int CollectionClass_ID { get; set; }

        [DisplayName("��������")]
        public string CollectionGroup_Name { get; set; }



        [Required]
        [DisplayName("���ղ���ҵ����")]
        public int Enterprise_ID { get; set; }

        [DisplayName("��ҵ����")]
        public string Enterprise_Name { get; set; }
        [DisplayName("��ע")]
        public string My_Description { get; set; }
        public Enterprise Enterprise { get; set; }//��������
        public CollectionClass CollectionClass { get; set; }//��������

    }
}
