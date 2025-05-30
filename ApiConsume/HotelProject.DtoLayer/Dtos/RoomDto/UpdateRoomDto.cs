﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomId { get; set; }
        [Required(ErrorMessage = "Lütfen oda numarası giriniz:")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen oda görseli giriniz:")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen oda başlığı bilgisi giriniz")]
        [StringLength(100, ErrorMessage = "Lütfen en fazla 100 karekter veri girişi yapınız")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısı  giriniz")]
        public string BadCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısı  giriniz")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen açıklamayı giriniz")]
        public string Description { get; set; }
    }
}
