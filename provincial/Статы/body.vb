﻿if throat = 0: $throat = 'У вас целомудренный <a href="exec:view''images/picb/throat/0.jpg''">ротик</a>.'&$throattipe='девственное'
if throat > 0 and throat <= 5: $throat = 'У вас неопытный <a href="exec:view''images/picb/throat/1.jpg''">ротик</a>.'&$throattipe='абсолютно непривычное'
if throat > 5 and throat <= 10: $throat = 'У вас рабочий ротик и чувствительное <a href="exec:view''images/picb/throat/2.jpg''">горло</a>.' & $throattipe='чувствительное'
if throat > 10 and throat <= 15: $throat = 'У вас опытный рот и слегка растянутое <a href="exec:view''images/picb/throat/3.jpg''">горло</a>.' & $throattipe='слегка растянутое'
if throat > 15 and throat <= 25: $throat = 'У вас вместительный рот и тренированное <a href="exec:view''images/picb/throat/4.jpg''">горло</a>.'& $throattipe='растянутое'
if throat > 25 and throat <= 35: $throat = 'Ваша глубокая лужёная <a href="exec:view''images/picb/throat/5.jpg''">глотка</a> может принять любой член.'& $throattipe='лужёное'
if throat > 35: $throat = 'У вас полностью отсутствует рвотный рефлекс, и ваша разработанная <a href="exec:view''images/picb/throat/6.jpg''">глотка</a> похожа на бездонный колодец, способный принять хоть телеграфный столб без ущерба для себя'& $throattipe='бездонное'
if vagina = 0: $vagina = 'У вас девственная <a href="exec:view''images/picb/pussy/0.jpg''">плева</a>.' & $vaginatipe='девственная' & $vaginatipe2 = 'девственную' & $vaginatipe3 = 'девственной'
if vagina > 0 and vagina <= 5: $vagina = 'Ваша <a href="exec:view''images/picb/pussy/1.jpg''">киска</a> очень узенькая.' & $vaginatipe = 'узенькая' & $vaginatipe2 = 'узенькую' & $vaginatipe3 = 'узенькой'
if vagina > 5 and vagina <= 10: $vagina = 'У вас тесная, похожая на щель <a href="exec:view''images/picb/pussy/2.jpg''">вагина</a>.' & $vaginatipe = 'тесная' & $vaginatipe2 = 'тесную' & $vaginatipe3 = 'тесной'
if vagina > 10 and vagina <= 15: $vagina = 'У вас эластичная <a href="exec:view''images/picb/pussy/3.jpg''">киска</a>.' & $vaginatipe = 'тугая' & $vaginatipe2 = 'тугую' & $vaginatipe3 = 'тугой'
if vagina > 15 and vagina <= 25: $vagina = 'У вас хорошо разработанная <a href="exec:view''images/picb/pussy/4.jpg''">вагина</a>.' & $vaginatipe = 'разработанная' & $vaginatipe2 = 'разработанную' & $vaginatipe3 = 'разработанной'
if vagina > 25 and vagina <= 35: $vagina = 'Между ног у вас зияет здоровенная <a href="exec:view''images/picb/pussy/5.jpg''">дыра</a>' & $vaginatipe = 'раздолбанная' & $vaginatipe2 = 'раздолбанную' & $vaginatipe3 = 'раздолбанной'
if vagina > 35: $vagina = 'То, что у вас на месте киски, больше похоже на <a href="exec:view''images/picb/pussy/6.jpg''">карьер</a>, в котором самосвал кажется блохой' & $vaginatipe = 'безразмерная' & $vaginatipe2 = 'безразмерную' & $vaginatipe3 = 'бездонной'
if analplugIN = 0:
	if anus = 0:anpic = 0 & $anus ='У вас девственный <a href="exec:view''images/picb/ass/0.jpg''">анус</a>' & $anustipe = 'девственный' & $anustipe2 = 'девственную' & $anustipe3 = 'девственной'
	if anus > 0 and anus <= 5:anpic = 1 & $anus = 'выглядит как крохотная щёлочка, куда даже карандаш боязно вставить.' & $anustipe = 'крошечный' & $anustipe2 = 'крошечную' & $anustipe3 = 'крошечной'
	if anus > 5 and anus <= 10:anpic = 2 & $anus = 'имеет форму звёздочки.' & $anustipe = 'тугой' & $anustipe2 = 'тугую' & $anustipe3 = 'тугой'
	if anus > 10 and anus <= 15:anpic = 3 & $anus = 'выглядит как щель.' & $anustipe = 'слегка растянутый' & $anustipe2 = 'слегка растянутую' & $anustipe3 = 'слегка растянутой'
	if anus > 15 and anus <= 25:anpic = 4 & $anus = 'выглядит как дупло.' & $anustipe = 'растянутый' & $anustipe2 = 'растянутую' & $anustipe3 = 'растянутой'
	if anus > 25 and anus <= 35:anpic = 5 & $anus = 'не закрывается и выглядит как красное раздолбанное дупло, из которого регулярно вылетают ветры.' & $anustipe = 'раздолбанный' & $anustipe2 = 'раздолбанную' & $anustipe3 = 'раздолбанной'
	if anus > 35:anpic = 6 & $anus = 'практически полностью уничтожен и представляет из себя бесформенную дыру.' & $anustipe = 'разрушенный' & $anustipe2 = 'разрушенную' & $anustipe3 = 'разрушеной'
	if anus > 0: $anus = 'Ваш <a href="exec:view''images/picb/ass/' + anpic + '.jpg''">анус</a> ' + $anus
elseif analplugIN = 1 and tanga = 1:
	$anus = 'В ваш <a href="exec:view''images/picb/ass/analplug.jpg''">анус</a> вставлена анальная пробка.'
elseif analplugIN = 1 and tanga = 0:
	if pirsG = 0 and pirsGL = 0: $anus = 'analplugnotanga'
	if pirsG = 1 and pirsGL = 1: $anus = 'analplugpirscligub'
	if pirsG = 0 and pirsGL = 1: $anus = 'analplugpirsclit'
	if pirsG = 1 and pirsGL = 0: $anus = 'analplugpirsring'
	$anus = 'В ваш <a href="exec:view''images/picb/ass/' + $anus + '.jpg''">анус</a> вставлена анальная пробка.'
end
! волосы и прическа
if shorthair = 3:
	hapri = 1
	curly = 0
end
if cheatHapri_mod = 0: hapri = 1
$hapri = iif(hapri = 0,'спутавшиеся','аккуратно уложенные')
$_haircolor = func('zz_funcs','get_item_string','чёрные,русые,рыжие,светлые',hcol)
$_haircurly = iif(curly=0,'прямые','кудрявые')
if shorthair >= 2:
	$hair = 'У вас '+iif(shorthair=2,'короткие ','очень короткие ') + iif(shorthair=2,$_haircurly,'') +' <<$_haircolor>> волосы.'
else
	$hair = 'У вас <<$hapri>> <<$_haircurly>> <<$_haircolor>> волосы' + iif(shorthair=0,'.',' средней длинны.')
end
$hair2 = $_haircolor + iif(curly=0,' кудри',' волосы')
killvar '$_haircolor'
killvar '$_haircurly'
!---
if lip > 4:lip = 4
if lip < 0:lip = 0
if lipbalmstat > 0:
	if lip = 0: $lipbalmstat = ', блестящие от бальзама' & $lipbalmstat2 = 'блестящим от бальзама'
	if lip = 1: $lipbalmstat = ', блестящие от бальзама' & $lipbalmstat2 = 'блестящим от бальзама'
	if lip = 2: $lipbalmstat = ', блестящие и сочные от бальзама' & $lipbalmstat2 = 'блестящим и сочным от бальзама'
	if lip = 3: $lipbalmstat = 'сочные,' & $lipbalmstat2 = 'сочным'
	if lip = 4: $lipbalmstat = ', лоснящиеся' & $lipbalmstat2 = 'лоснящимся'
else
	$lipbalmstat = ''
end
vidagebonus = iif(vidage < 21,0,iif(vidage < 26,5,iif(vidage < 31,10,iif(vidage < 41,20,40))))
$pirsA = iif(pirsA=0,'','Иногда при разговоре у вас во рту заметен <a href="exec:dynamic $dipirsA">пирсинг языка</a>.')
$pirsB = iif(pirsB=0,'','Нижняя губа проколота и в неё вдето кольцо.')
$pirsC = iif(pirsC=0,'','В ушах болтаются серёжки.')
$pirsD = iif(pirsD=0,'','В ваш нос вставлено кольцо.')
$pirsE = iif(pirsE=0,'','Ваша бровь проколота и туда вставлена штанга.')
if lip = 0:$lip = 'У вас тонкие <<$lipbalmstat>> губы. <<$pirsB>> <<$pirsA>>' & $liptalk = 'тонкими губами' & $liptalk2 = 'тонким губам' & $liptalk3 = 'тонкие губы'
if lip = 1:$lip = 'У вас нормальные <<$lipbalmstat>> губы. <<$pirsB>> <<$pirsA>>' & $liptalk = 'нежными губами' & $liptalk2 = 'нежным губам' & $liptalk3 = 'нежные губы'
if lip = 2:$lip = 'У вас пухленькие <<$lipbalmstat>> губы. <<$pirsB>> <<$pirsA>>' & $liptalk = 'пухленькими губами' & $liptalk2 = 'пухленьким губам' & $liptalk3 = 'пухленькие губы'
if lip = 3:$lip = 'У вас крупные, <<$lipbalmstat>> пухлые губы. <<$pirsB>> <<$pirsA>>' & $liptalk = 'пухлыми губами' & $liptalk2 = 'пухлым губам' & $liptalk3 = 'пухлые губы'
if lip = 4:$lip = 'У вас толстые и огромные <<$lipbalmstat>> губы. <<$pirsB>> <<$pirsA>>' & $liptalk = 'толстыми губами' & $liptalk2 = 'толстым губам' & $liptalk3 = 'толстые губы'
if tan = 0: tankoef = 0 & $tan = 'бледная'
if tan > 0 and tan <= 30: tankoef = 1 & $tan = 'слегка загорелая'
if tan > 30 and tan <= 100: tankoef = 5 & $tan = 'загорелая'
if tan > 100: tankoef = 10 & $tan = 'смуглая от загара'
if skin = 0: $skin = 'Ваша <<$tan>> кожа неровная и покрыта прыщами и чёрными точками. <<$pirsC>> <<$pirsD>> <<$pirsE>>'
if skin = 1: $skin = 'Ваша <<$tan>> кожа неровная и кое-где заметны прыщики. <<$pirsC>> <<$pirsD>> <<$pirsE>>'
if skin = 2: $skin = 'Ваша <<$tan>> кожа неровная, но прыщей не видно. <<$pirsC>> <<$pirsD>> <<$pirsE>>'
if skin = 3: $skin = 'У вас <<$tan>> гладкая и ухоженная кожа. <<$pirsC>> <<$pirsD>> <<$pirsE>>'
if skin = 4: $skin = 'У вас <<$tan>> гладкая как стекло и шелковистая даже на вид кожа. <<$pirsC>> <<$pirsD>> <<$pirsE>>'
if glacol = 0: $glacol = 'карие' & $glacol2 = 'карими'
if glacol = 1: $glacol = 'серые' & $glacol2 = 'серыми'
if glacol = 2: $glacol = 'зеленые' & $glacol2 = 'зелеными'
if glacol = 3: $glacol = 'голубые' & $glacol2 = 'голубыми'
if resnic > 2: resnic = 2
if resnic = 0: $resnic = 'с короткими ресницами'
if resnic = 1: $resnic = 'с нормальной длинны ресницами'
if resnic = 2: $resnic = 'с длинными ресницами'
if brow = 0 and browper = 0:$brow = 'немного неаккуратные брови'
if brow > 0 and browper = 0:$brow = 'ухоженные брови' & brokoef = 2
if browper > 0:$brow = 'перманентный татуаж бровей' & brokoef = 1
if glass <= 0:$glass = iif(colorful_lenses > 0,'Вы носите стильные цветные контактные линзы без диоптрий.','') & glassvnesh = 0
if glass = 1:$glass = ' Вы носите дурацкие гадские очки в дешёвой оправе '+iif(colorful_lenses > 0,'и стильные цветные контактные линзы без диоптрий.','.') & glassvnesh = -3
if glass = 2:$glass = ' Вы носите очки '+iif(colorful_lenses > 0,'и стильные цветные контактные линзы без диоптрий.','.') & glassvnesh = 0
if glass = 3:$glass = ' Вы носите дорогие модные очки '+iif(colorful_lenses > 0,'и стильные цветные контактные линзы без диоптрий.','.') & glassvnesh = 1
if glaraz > 3:glaraz = 3
if glaraz = 0:$glaza = 'У вас маленькие <<$glacol>> глаза, <<$resnic>> и <<$brow>>.<<$glass>>' & $glaza2 = '<<$glacol>> глаза' & $glaza3 = '<<$glacol2>> глазами'
if glaraz = 1:$glaza = 'У вас выразительные <<$glacol>> глаза, <<$resnic>> и <<$brow>>.<<$glass>>' & $glaza2 = 'выразительные <<$glacol>> глаза' & $glaza3 = 'выразительными <<$glacol2>> глазами'
if glaraz = 2:$glaza = 'У вас большие <<$glacol>> глаза, <<$resnic>> и <<$brow>>.<<$glass>>' & $glaza2 = 'большие <<$glacol>> глаза' & $glaza3 = 'большими <<$glacol2>> глазами'
if glaraz = 3:$glaza = 'У вас огромные <<$glacol>> глаза, <<$resnic>> и <<$brow>>.<<$glass>>' & $glaza2 = 'огромные <<$glacol>> глаза' & $glaza3 = 'огромные <<$glacol2>> глаза'
if mop = 0:$mop = '<b><font color = red>У вас потёк макияж.</font></b>'
if mop = 1:$mop = 'У вас нет макияжа'
if mop = 2:$mop = 'У вас легкий макияж'
if mop = 3:$mop = 'У вас нормальный макияж'
if mop = 4:$mop = 'У вас яркий, вызывающий макияж'
if leghair <= 0: legkoef = 0 & $leghair = 'У вас гладкие ноги.'
if leghair > 0 and leghair <= 2: legkoef = 3 & $leghair = 'У вас не видимая глазу, но шершавая на ощупь щетина на ногах.'
if leghair > 2 and leghair <= 5: legkoef = 10 & $leghair = 'У вас отчётливо видимые тонкие волосики на ногах.'
if leghair > 5: legkoef = 20 & $leghair = 'У вас длинные выделяющиеся волосы на ногах.'
if pirsG = 1 and pirsGL = 0:$pirspiz = 'На половых губах висят колечки.'
if pirsG = 0 and pirsGL = 1:$pirspiz = 'В клитор вставлена штанга.'
if pirsG = 1 and pirsGL = 1:$pirspiz = 'У вас проколот клитор и в половые губы вставлены колечки'
if lobok <= 0: $lobok = 'У вас гладкий, <a href="exec:view''images/picb/pussy/shaved.jpg''">выбритый лобок</a>.<<$pirspiz>>' & $lobok2 = 'гладковыбритый лобок' & $lobok3 = 'гладковыбритому лобку'
if lobok > 0 and lobok <= 2: $lobok = 'У вас <a href="exec:view''images/picb/pussy/trim.jpg''">не большая щетина на лобке</a>.<<$pirspiz>>' & $lobok2 = 'покрытый легкой щетиной лобок' & $lobok3 = 'покрытому легкой щетиной лобку'
if lobok > 2: $lobok = 'У вас <a href="exec:view''images/picb/pussy/hairy.jpg''">волосатый лобок</a>.<<$pirspiz>>' & $lobok2 = 'волосатый лобок' & $lobok3 = 'волосатому лобку'
if StrongNarkota > 0 and SLomka > 0: SLomka = 0
! --- ТЕЛО --- !
gs 'zz_body'
if body['group'] = 0:
	if (stren + vital) >= 50:
		$body = 'Вы очень тонкая девушка, с маленькой мягкой попой и у вас еле заметны мышцы.'
	else
		$body = 'Вы очень тонкая девушка, с маленькой мягкой попой и у вас практически полностью отсутствуют мышцы.'
	end
elseif body['group'] = 1:
	if (stren + vital) < 50:
		$body = 'Вы стройная девушка.'
	elseif (stren + vital) >= 50 and (stren + vital) < 100:
		$body = 'Вы стройная девушка с отчётливо заметными мышцами.'
	else
		$body = 'Вы спортивная девушка с поджарой мускулистой фигурой.'
	end
elseif body['group'] = 2:
	if (stren + vital) >= 50:
		$body = 'Вы формастая девушка, весьма пухленькая.'
	else
		$body = 'Вы формастая девушка.'
	end
elseif body['group'] = 3:
	if (stren + vital) >= 50:
		$body = 'Вы жирноватая девушка, ваши мышцы заплыли жиром.'
	else
		$body = 'Вы жирноватая девушка.'
	end
elseif body['group'] = 4:
	if (stren + vital) >= 50:
		$body = 'Вы жирная девушка, ваши мышцы давно заплыли жиром.'
	else
		$body = 'Вы жирная девушка.'
	end
end
!---------------------------------
! грудь в зависимости от предпочтений
if $settings['body_tits'] = 0:
	! маленькая
	zz_tits = 20 - body['tits']*3
elseif $settings['body_tits'] = 1:
	! средняя
	if body['tits'] < 3:
		zz_tits = 20 - (3 - body['tits']) * 6
	elseif body['tits'] > 3:
		zz_tits = 20 - (body['tits'] - 3) * 6
	else
		zz_tits = 20
	end
else
	! большая
	zz_tits = body['tits']*3 + 2
end
! если гг одетая - делим на 2
!if current_clothing > 0: zz_tits = zz_tits/2
!---
! расчет коэффициента привлекательности тела в зависимости от предпочтений $settings['bodytype']
! 0 - худышка
! 1 - обычная
! 2 - толстушка
if $settings['bodytype'] = 0:
	bodykoef = 15 - body['group'] * 5
elseif $settings['bodytype'] = 2:
	bodykoef = body['group'] * 5 - 5
else
	bodykoef = iif(body['group']=0,10,20 - body['group']*5)
end
! для нежирных тел добавляем бонус за мускулистость
if body['group'] <= 2: bodykoef += (stren + vital)/40
!----
! для голого тела включаем в расчет бритость/волосатость лобка в зависимости от предпочтений $settings['pubic_hair']
! 0 - бритый
! 1 - волосатый
if current_clothing = 0:
	! по умолчанию - бритый
	if lobok <= 0:
		lobkoef = 20
	elseif lobok > 0 and lobok <= 2:
		lobkoef = 0
	else
		lobkoef = -20
	end
	! для волосатого получаем обратное значение - умножаем на -1
	if $settings['pubic_hair'] = 1: lobkoef = -1*lobkoef
else
	lobkoef = 0
end
! бонус одежды - только для одетой ГГ
if current_clothing = 0:
	! голая
	odevnesh = 0
elseif current_clothing = 1:
	! в полотенце
	odevnesh = 3
elseif current_clothing = 2:
	! в купальнике
	odevnesh = 7
elseif current_clothing > 2:
	! в зависимости от типа одежды
	odevnesh = func('zz_clothing','get_view_bonus')
end
!---
! волосатость ног не видна под джинсами, леггинсами и спорткостюмом
_cur_cloth_group = func('zz_clothing','get_group')
if _cur_cloth_group = 2 or _cur_cloth_group = 3 or _cur_cloth_group = 6: legkoef = 0
killvar '_cur_cloth_group'
!---
! бонусы
vnesh = iif(curly = 0,0,3) + zz_tits + iif(lip=4,-1,lip)+iif(colorful_lenses > 0,1,0) + tankoef + skin + mop*2 + resnic + iif(glaraz>0,1,0) + bodykoef + lobkoef + odevnesh + iif(lipbalmstat > 0,1,0) + brokoef + glassvnesh + iif(cheatHapri_mod = 1 and hapri = 0,0,2)
! штрафы
vnesh -= iif(sweat<=0,0,sweat*5) + zub*2 + legkoef + dirtyclothes*20 + fingal*2 + vidagebonus
!---------------------------------
killvar 'zz_tits'
if vnesh < 0:
	vnesh = 0
	if StrongNarkota <= 0: if SNarkTimes >= 3 and SLomka = 0: SLomka = 1
	if Gerpes >= 3 or Sifilis >= 21 or Triper > 2:vnesh = -10
end
if vnesh = -10: $vnesh = 'У вас заметны признаки венерического заболевания. Поэтому парни разбегаются в ужасе.'
if vnesh >= 0 and vnesh < 20: $vnesh = 'У вас страшная внешность. Парни от вас шарахаются.'
if vnesh >= 20 and vnesh < 40: $vnesh = 'У вас серенькая внешность. Парни практически вас не замечают.'
if vnesh >= 40 and vnesh < 60: $vnesh = 'У вас симпатичная внешность. Парни частенько обращают на вас внимание.'
if vnesh >= 60 and vnesh < 80: $vnesh = 'У вас сногсшибательная внешность. Парни постоянно оборачиваются видя вас.'
if vnesh >= 80: $vnesh = 'У вас просто божественная внешность. Парни сами падают к вашим ногам.'