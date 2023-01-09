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
