
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public partial class Order
    {
        [Key]
        [DisplayName("��������")]
        public int Order_ID { get; set; }

        [Required]
        [DisplayName("������ҵ����")]
        public int PublisherEnterprise_ID { get; set; }
        [Required]
        [DisplayName("������ҵ����")]
        public int ProviderEnterprise_ID { get; set; }
        [DisplayName("���������ɺ�ͬ�û�")]
        public int PublisherUser_ID { get; set; }
        [DisplayName("������ǩ����ͬ�û�")]
        public int ProviderUser_ID  { get; set; }
        public string Order_Name { get; set; }
        [DisplayName("�ϼ���������")]
        public Nullable<int> PIDOrder_ID { get; set; }
        [DisplayName("�������")]
        public string Order_Code { get; set; }
        [DisplayName("��ͬ�ļ���ַ")]
        public string Contract_Addr { get; set; }

        [DisplayName("��ͬ�ļ������ַ")]
        public string Contract_Browse_Addr { get; set; }
        [DisplayName("��ͬ���ص�ַ")]
        public string Contract_Download_Addr { get; set; }
        [DisplayName("��ͬ�޸Ľ���")]
        public string Contact_Suggestion { get; set; }

        [Required]
        [DisplayName("��������")]
        public string Order_Content { get; set; }

        [Required]
        [DisplayName("��������ʱ��")]
        public string Order_Time { get; set; }
        [DisplayName("�Ƿ����Ӷ���")]
        public bool Sub_Orders { get; set; }
        [Required]
        [DisplayName("������ɾ������")]
        public bool Publisher_Del { get; set; }

        [Required]
        [DisplayName("������ɾ������")]
        public bool Provider_Del { get; set; }   
        [DisplayName("�Ƿ��Ѿ��Ķ�")]
        public bool ReadOrNot { get; set; }//Ϊfalseʱ��ʾδ����Ϊtrueʱ��ʾ�Ѷ���
        //��������
        public Enterprise Publisher { get; set; }
        public Enterprise Provider { get; set; }
        public Order PID { get; set; }
     
    }
}
