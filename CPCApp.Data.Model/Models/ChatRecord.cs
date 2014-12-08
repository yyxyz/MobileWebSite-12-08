using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public partial class ChatRecord
    {
        [Key]
        [DisplayName("�����¼����")]
        public int ChatRecord_ID { get; set; }

        [Required]
        [DisplayName("���ͷ�����")]
        public int SendEnterprise_ID { get; set; }

        [Required]
        [DisplayName("���շ�����")]
        public int ReceiveEnterprise_ID { get; set; }

        [DisplayName("��������")]
        public string Chat_Content { get; set; }


        [Required]
        [DisplayName("����ʱ��")]
        public string Chat_Time { get; set; }


        [Required]
        [DisplayName("���ͷ��Ƿ�ɾ������")]
        public bool Send_Enterprise_Del { get; set; }

        [Required]
        [DisplayName("���շ��Ƿ�ɾ������")]
        public bool Receive_Enterprise_Del { get; set; }

        [Required]
        [DisplayName("��Ϣ�Ѷ����")]
        public bool Read { get; set; }


        //��������
        public Enterprise Send { get; set; }
        public Enterprise Receive { get; set; }

    }
}
