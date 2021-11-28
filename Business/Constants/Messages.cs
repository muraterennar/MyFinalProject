using Core.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string PrductAdded = "Ürün Eklendi";
        public static string PrductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir Kategoride En Fazla 15 Ürün Bulunabilir !";
        public static string ProductNameAlreadryExists = "Aynı İsimde Ürün Zaten Var";
        public static string CategoryLimitExceded = "Kategori Liit Aşıldığı İçin Yeni Ürün Eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz Yok";
        public static string UserRegistered = "Kullanıcı Başarıyla Eklendi";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string PasswordError = "Parola Hatası";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
