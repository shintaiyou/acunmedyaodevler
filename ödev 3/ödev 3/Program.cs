using System.Net.Http.Headers;
using ödev_3.NewFolder;

genelmüdür g = new genelmüdür();
g.rol = "genel müdür";
g.maas = 80000;
g.yazdir(g.rol, g.maas);
müdür m = new müdür();
m.rol = "müdür";
m.maas = 60000;
m.yazdir(m.rol, m.maas);
programcı p = new programcı();
p.rol = "programcı";
p.maas = 40000;
p.yazdir(p.rol, p.maas); 
stajyer s   = new stajyer();
s.rol = "stajyer";
s.maas = 5000;
s.yazdir(s.rol, s.maas); 