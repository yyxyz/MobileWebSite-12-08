using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public partial class OrderStatus
    {
        public enum orderStatusType
        {
          contractUnsinged=0,//��ͬδǩ��
          contractSinged=1,//��ͬǩ��
          orderProccessing=2,//������������
          orderProccessed=3,//����������ɣ�����ʾ���Ͱ�ť
          orderDelivery = 4,//������ɣ�����ʾ���Ͱ�ť
          orderReceived=5,//�ͻ�ȫ��ǩ��
          orderCommented=6//�ͻ�������
        }
        [Key]
        [DisplayName("����״̬����")]
        public int OrderStatus_ID { get; set; }

        [Required]
        [DisplayName("��������")]
        public int Order_ID { get; set; }

        [Required]
        [DisplayName("����״̬����")]
        public orderStatusType OrderStatus_Content { get; set; }
        [Required]
        [DisplayName("����״̬ʱ��")]
        public string OrderStatus_Time { get; set; }
        public Order Order { get; set; }//��������
    }
}
