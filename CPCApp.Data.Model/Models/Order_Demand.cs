using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public partial class Order_Demand
    {
        [Key]
        [DisplayName("���������ϵ����")]
        public int Order_Demand_ID { get; set; }
        
        [Required]
        [DisplayName("��������")]
        public int Demand_ID { get; set; }

        [Required]
        [DisplayName("��������")]
        public int Order_ID { get; set; }
        [Required]
        [DisplayName("���Զ���")]
        public bool ViewOrder_JudgeSubOrder { get; set; }//���Ϊfalse���ǲ����Ӷ���ʱ���õ��жϸ������Ƿ����Զ��������Ϊtrue������ViewOrder��ΪFlase����SubOrder��
        public Order Order { get; set; }//��������
        public Demand Demand { get; set; }//��������
    }
}
