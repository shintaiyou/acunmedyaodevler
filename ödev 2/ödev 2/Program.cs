using ödev_2.ödev;

Bmw b = new Bmw();
b.marka = "bmw";
b.sür = "cok hızlı gider";
b.yüz = "denizde yüzer";
b.uc = "havada ucar";
b.yazdir(b.marka ,b.sür, b.yüz, b.uc);
Mercedes m = new Mercedes();
m.marka = "mercedes";
m.yüz = "denizde yüzer";
m.uc = "havada ucar";
m.yazdir1(m.marka,m.yüz, m.uc);
Porsche p = new Porsche();
m.marka = "porsche";
p.uc = "hava ucar";
p.yazdir2(m.marka,m.uc);
