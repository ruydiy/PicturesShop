# PicturesShop
PicturesShop.net

Приложението представлява online магазин за картини.

Потребителите са два вида:

-> User - Всеки потребител получава тази роля при регистрацията си.   

-> Admin - Той има възможността да добавя(add), изтрива (delete), променя (edit) картини, авторите им, жанра на картините, цената им, галерията на публикуването им и също така да обработва поръчки.

Бизнес логиката (контролерите) е разделена от логиката, която работи с базата данните, чрез създадени репозиторита (repositories). Controllers са свързани с repositories чрез services, за да бъде валидиран кода и ограничена възможносттра за възникване на грешка.
