# 👨‍⚕️ EMS Responding Service 👨‍⚕️

[![forthebadge](https://forthebadge.com/images/badges/made-with-c-sharp.svg)](https://forthebadge.com)
[![forthebadge](https://forthebadge.com/images/badges/built-with-love.svg)](https://forthebadge.com)


## 💻 Login do systému 💻

![image](https://i.imgur.com/gl2HwPw.png)

> - #### Pro přihlášení do systému stačí v první kolonce vybrat jméno uživatele a do druhé kolonky následně zadat heslo uživatele.
> - #### Po zadání hesla stačí kliknout na tlačítko s nápisem Login.

## 🏥 UI aplikace 🏥

![image](https://i.imgur.com/n5IjWW1.png)

> - #### V levé části aplikace se nachází navigační menu.
> - #### V horní části lze vidět přihlášeného uživatele a jeho hodnost.

## 💾 Zobrazení dat 💾

![image](https://i.imgur.com/R9jHdnN.png)

![image](https://i.imgur.com/ckzm9V7.png)

![image](https://i.imgur.com/zFGAfGQ.png)

![image](https://i.imgur.com/a8wHjB2.png)

> - #### Většina části aplikace zabírá panel s výjezdy, doktory, pacienty a auty.
> - #### Pro zobrazení vámi chtěných dat stačí kliknout v navigačním menu co chcete zobrazit.

```c#
private void UpdateResponds()
        {
            _pnlResponds.Controls.Clear();
            int index = 0;
            foreach (var respond in _responds)
            {
                RespondItemControl control = new(respond);
                control.Location = new Point(0, (control.Height * index) + 10);
                control.OnItemClick += Control_OnItemClick;
                control.OnDeleteClick += Control_OnDeleteClick;
                _pnlResponds.Controls.Add(control);
                index++;
            }
        }
```

## 🔐 Změna hesla 🔐

![image](https://i.imgur.com/L3YIaYm.png)

> - #### Pro změnu hesla stačí otevřít poslední položku v navigačním menu.
> - #### Zde zadáte vaše současné heslo a vaše nové heslo, poté ho zopakujete.

## ➕ Přidání dat ➕

![image](https://i.imgur.com/IiEIs9v.png)

> - #### Pro přidání vámi určených dat stačí kliknout na tlačítko **Add** ve spodní části navigačního menu.
> - #### Vždy ve které části jste (Responds, Doctors...), tak tyto data přidáváte.

## 📋 Úprava dat 📋

![image](https://i.imgur.com/0LIbPgM.png)

> - #### Pro úpravu dat stačí kliknout na libovolnou položku z panelu a zobrazí se vám nové okno pro edit této položky.
