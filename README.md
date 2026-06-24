<div align="center">

#  Builder Design Pattern

### Karmaşık nesneleri adım adım, okunabilir ve esnek biçimde inşa etmek.

<br>

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Design Pattern](https://img.shields.io/badge/PATTERN-Builder-FF6B35?style=for-the-badge)
![OOP](https://img.shields.io/badge/OOP-Creational-8A2BE2?style=for-the-badge)

![Lisans](https://img.shields.io/badge/Lisans-MIT-brightgreen?style=flat-square)
![Durum](https://img.shields.io/badge/Durum-Tamamland%C4%B1-success?style=flat-square)
![Örnek](https://img.shields.io/badge/%C3%96rnek-Araba%20%26%20Pizza-blueviolet?style=flat-square)

</div>

---

## 🎯 Proje Hakkında

> **Amaç:** Çok sayıda parametre alan ve okunması zorlaşan constructor'lardan kaçınarak, bir nesneyi **adım adım** kuran temiz bir yapı oluşturmak.

Gerçek projelerde bir nesnenin onlarca özelliği olabilir. Hepsini tek bir constructor'a sığdırmak hem okunaksızdır hem de hataya açıktır. **Builder Pattern**, bu kuruluş sürecini nesnenin kendisinden ayırarak çözer.

Bu repo, deseni iki somut örnekle gösterir:

- 🚗 **Araba** — varsayılan değerlerle başlayıp istenen özelliklerin değiştirildiği yapı
- 🍕 **Pizza** — istenen malzemelerin tek tek seçildiği yapı

---

## 🧩 Desenin Parçaları

| Parça | Görevi | Örnekteki Karşılığı |
|-------|--------|---------------------|
| **Product** | Üretilecek nihai nesne | `Araba`, `Pizza` |
| **Builder** | Nesneyi parça parça kuran sınıf | `ArabaBuilder`, `PizzaBuilder` |
| **Director** | Hazır tarifleri tanımlayan sınıf | `ArabaDirector`, `PizzaDirector` |
| **Client** | Yapıyı kullanan kod | `Main` |

---

## ⛓️ Method Chaining (Zincirleme)

Her `Set...` metodu `return this;` döndürdüğü için çağrılar zincirlenebilir. Bu, kodu hem kısa hem de okunaklı yapar:

```csharp
var araba = new ArabaBuilder()
    .Setrenk("Mavi")
    .SetHp(150)
    .SetVites("Otomatik")
    .SetYakit("Dizel")
    .Build();
```

---

## 🚗 Örnek 1: Araba

`Araba`, constructor'ında **varsayılan değerlerle** başlar:

| Özellik | Varsayılan |
|---------|------------|
| Renk    | Beyaz      |
| Hp      | 75         |
| Vites   | Manuel     |
| Yakit   | Benzin     |

`ArabaBuilder` ile bu değerler istenildiği gibi değiştirilir.
`ArabaDirector` ise sık kullanılan paketleri hazır sunar:

- `EkoSinifAraba()` → SimliBeyaz · 100 Hp · Yarı-Otomatik · Dizel
- `OrtaSinifAraba()` → Kırmızı · 120 Hp · Otomatik · Benzin

---

## 🍕 Örnek 2: Pizza

`Pizza` nesnesinin özellikleri: **Boyut, HamurTipi, Peynir, Zeytin, Mantar**.
`PizzaBuilder` ile istenen malzemeler seçilir.
`PizzaDirector` hazır tarifleri sunar:

- `OrtaPizza()` → Orta · Kalın hamur · Peynirli
- `KarisikPizza()` → Büyük · İnce hamur · Peynirli

---

## ▶️ Çalıştırma

```bash
dotnet run
```

---

## ✨ Neden Builder?

- ✅ Uzun ve karışık constructor'lara gerek kalmaz
- ✅ Hangi özelliğin ne olduğu çağrı sırasında **açıkça** görünür
- ✅ `Director` ile sık kullanılan kombinasyonlar tek satırda üretilir
- ✅ Yeni özellik eklemek kolaydır — sadece yeni bir `Set...` metodu yazılır

> 💡 **Not:** `PizzaBuilder`'a `SetZeytin()` ve `SetMantar()` metotları eklenerek desen kolayca genişletilebilir.

---

<div align="center">

Builder Pattern · C# · OOP

</div>
