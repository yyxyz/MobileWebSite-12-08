using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public partial class DemandStatus
    {
        public enum demandStatusType
        {
            demandRelease=0,//���󷢲��׶�
            demandBid=1,//���󾺱�׶�
            demandBidFinished=2//���󾺱����
        }

        [Key]
        [DisplayName("����״̬����")]
        public int DemandStatus_ID { get; set; }

        [Required]
        [DisplayName("��������")]
        public int Demand_ID { get; set; }


        [Required]
        [DisplayName("״̬����")]
        public demandStatusType Status_Content { get; set; }


        [Required]
        [DisplayName("״̬ʱ��")]
        public string Status_Time { get; set; }

        //��������
        public Demand Demand { get; set; }
    }
}
