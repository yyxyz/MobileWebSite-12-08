using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public class Bid
    {
        [Key]
        [DisplayName("���귽������")]
        public int Bid_ID { get; set; }

        [Required]
        [DisplayName("��������")]
        public int Demand_ID { get; set; }

        [DisplayName("��������")]
        public string Demand_Name { get; set; }
        [Required]
        public int ProviderUser_ID { get; set; }//������ҵ�û�
        
        [DisplayName("������ҵ����")]
        public int Enterprise_ID { get; set; }

        [DisplayName("������ҵ����")]
        public string Enterprise_Name { get; set; }


        [Required]
        [DisplayName("���귽�����ݼ��")]
        public string Bid_Content { get; set; }

        public enum BidStateType
        {
            Bidding=0,
            BidSelected=1,
            BidUnselected=2
        }

        [Required]
        [DisplayName("�Ƿ��б�")]
        public BidStateType BidState { get; set; }

        [Required]
        [DisplayName("����ʱ��")]
        public string Bid_Time { get; set; }

        [DisplayName("���귽���ļ���ַ")]
        public string bidFilePath { get; set; }

        [DisplayName("���귽���ļ���ַ")]
        public string bidFileBrowsePath { get; set; }


        public Enterprise Enterprise { get; set; }//��������
        public Demand Demand { get; set; }//��������
    }
}
