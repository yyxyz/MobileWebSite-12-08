using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public partial class User
    {  
       
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [DisplayName("�û�������")]
        public int User_ID { get; set; }
        [Required]
        [DisplayName("��ҵ���")]
        public int Enterprise_ID { get; set; }
        [Required]
        [DisplayName("����")]
        public string Password { get; set; }
        
        [DisplayName("Ա�����")]
        public int User_Code { get; set; }
        
        [DisplayName("�û�����")]
        public string User_Name { get; set; }
        
        [DisplayName("���֤")]
        public string User_Card { get; set; }
        
        [DisplayName("�û���Ƭ")]
        public byte[] User_Photo { get; set; }


        [DisplayName("�û�����")]
        public string User_Birthday { get; set; }
        
        [DisplayName("��������")]
        public int InternalOrganization_ID { get; set; }
       
        [DisplayName("�û�ְλ")]
        public string User_Position { get; set; }

        [DisplayName("ְλ����")]
        public string User_Position_Des { get; set; }
        
        [DisplayName("�û��Ա�")]
        public bool User_Sex { get; set; }
        
        [Phone]
        [DisplayName("��ϵ�绰")]
        public string User_Tel { get; set; }

        [DisplayName("�û���ַ")]
        public string User_Addr { get; set; }
        
        [EmailAddress]
        [DisplayName("�û�����")]
        public string User_Email { get; set; }
        
        [DisplayName("�û�״̬")]
        public bool User_State { get; set; }
       
        [DisplayName("�û�����ʱ��")]
        public string User_Create_Time { get; set; }

        [DisplayName("�û���ע")]
        public string User_Option { get; set; }

        
       
    }
}
