﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class AddRoomDto
    {
        [Required(ErrorMessage = "Lütfen oda numarası giriniz:")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen oda başlığı bilgisi giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısı  giriniz")]
        public string BadCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısı  giriniz")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
