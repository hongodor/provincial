﻿$metka = $ARGS[0]
$loc = $CURLOC
*clr & cla
gs 'stat'
gs 'time'
$control_point = $curloc
$_str = 'Центром Северного района, когда-то промышленной окраины, является громадный ' + func('zz_funcs','mk_link',8,20,'спортивно-концертный комплекс “Турбина”','skk')
$_str += ', расположившийся в бывших цехах одноимённого завода. Неподалёку есть <a href="exec:gt''vokzal''">Ж/д вокзал</a>.**'
$_str += 'На задах “Турбины” за длинным бетонным забором находится ' + func('zz_funcs','mk_link',8,21,'Складской терминал','Terminal')
$_str += ', и ' + func('zz_funcs','mk_link',9,17,'Авторынок','autotraidF')
$_str += ', вокруг которого скучковались ' + func('zz_funcs','mk_link',9,17,'Автомастерская','autoservisF')
$_str += ' и ' + func('zz_funcs','mk_link',9,17,'Автосалон','autosalonF') + '.**'
if ((school['certificate'] = 0 and bumtolik = 0) or bumtolik > 3): $_str += 'У самых путей притулилась рядом с отделением полиции ' + func('zz_funcs','mk_link',9,17,'“Клиника милосердия”','buklinik') + ', а по-сути - благотворительная ночлежка для бомжей.'
$_str += 'На привокзальной площади - вход в ' + func('zz_funcs','mk_link',5,23,'метро “Северный вокзал”','metro') + ' и '+ func('zz_funcs','mk_link',12,4,'шашлычная "Шампур"','lakecafe')+'.**'
$_str += 'Район старый, в основном “сталинской” застройки, и ныне становится всё престижнее и дороже. В нём множество кафешек, клубов, театров и галерей, среди которых ископаемым динозавром советской эпохи высится старый обшарпанный ' + func('zz_funcs','mk_link',9,19,'ДК имени Ленина','dk')+'.**'
$_str += 'Станция метро смотрит на северный вход в <a href="exec:gt''zz_park''">Парк Победы</a>, который в народе зовут “Бедой”, соединяющий все районы города.**'
$_str += 'Ярким пятном на пустыре стоит ' + func('zz_funcs','mk_link',8,20,'Супермаркет','shop') + '.**'
$_str += 'Под вывеской "Лотерея" на виду у всех работает ' + func('zz_funcs','mk_link',10,20,'Зал игровых автоматов','gamehall') + '. В мешанине дворов спрятался ' + func('zz_funcs','mk_link',12,19,'Пирсинг-салон','pirsingsalon') + '.**'
$_str += 'Северной границей района является <a href="exec:minut += 15 & nroad = 0 & gt ''road''">шоссе</a>, отделяющее город от близлежащих угодий.'
gs 'zz_render','Северный район',func('zz_funcs','mk_image','city/north/north'),$_str
killvar '$_str'
gs 'zz_funcs', 'waiting'
if _taxi_time >= 0: gs 'taxi','check'
gs 'car', 'check'
gs 'zz_dyns', 'street_cum'
!---
! продвижение Сони
if $npc['25,qwSonya'] = 95 and $npc['25,qwSonya_day'] ! day and hour >= 11 and hour <= 17:
	act 'Заняться продвижением Сони': gt 'sonya','sonya_promo_init'
end