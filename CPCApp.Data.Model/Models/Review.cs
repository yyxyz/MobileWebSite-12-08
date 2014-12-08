using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public partial class Review
    {

        [Key]
        [DisplayName("��������")]
        public int Review_ID { get; set; }
        [DisplayName("��������")]
        public int Order_ID{get;set;}
        [Required]
        [DisplayName("��������ҵ����")]
        public int ReceiveEnterprise_ID { get; set; }//��������ҵ

        [Required]
        [DisplayName("������ҵ����")]
        public int PublishEnterprise_ID { get; set; }//������ҵ

        [Required]
        [DisplayName("��������")]

        public string Review_Content { get; set; }

        public enum reviewclass
        {
            publisher, provider
        }

        [Required]
        [DisplayName("��������")]
        public reviewclass Review_Class { get; set; } //�����۶���

        [Required]
        [DisplayName("����ʱ��")]
        public string Review_Time { get; set; }

        //��������
        public Enterprise Receive { get; set; }
        public Enterprise Publish { get; set; }
        public Order Order { get; set; }
    }
}
