﻿if $ARGS[0] = 'start':
	$sexloc = $CURLOC
	gs'stat'
	'<center><b><font color = maroon>Фитнес центр</font></b></center>'
	'<center><img src="images/pic/fit.jpg"></center>'
	act 'Уйти':gt'fit','razd'
end
if $ARGS[0] = '0':
	$sexloc = $CURLOC
	cla
	*clr
	gs 'zz_render', '', 'images/img/centr/zal1.jpg', func('zal_strings', 'local_str1')
	act 'Уйти':gt'fit','razd'
	if dom > 0:
		act 'Домогаться':
			cla
			*clr
			guy += 1
			picrand = 17
			gs 'zz_render', '', 'images/img/centr/zal2.jpg', func('zal_strings', 'local_str2')
			act 'Сосать':gt'sex','minet'
		end
	end
end
if $ARGS[0] = '1':
	$sexloc = $CURLOC
	cla
	*clr
	gs 'zz_render', '', 'images/img/centr/zal3.jpg', func('zal_strings', 'local_str3')
	if dom > 0:act 'Дать по яйцам':gt'fit','razd'
	act 'Наслаждаться':
		cla
		*clr
		guy += 1
		picrand = 18
		gs 'zz_render', '', 'images/img/centr/zal4.jpg', func('zal_strings', 'local_str4')
		act 'Сосать':gt'sex','minet'
	end
end
if $ARGS[0] = '2':
	$sexloc = $CURLOC
	cla
	gs 'zz_render', '', '', func('zal_strings', 'local_str5')
	act 'Отказаться':gt'fit','razd'
	act 'Согласиться':
		cla
		*clr
		picrand = 15
		gs 'zz_render', '', 'images/img/centr/zal5.jpg', func('zal_strings', 'local_str6')
		act 'Послать извращенцев':gt'fit','razd'
		act 'Наслаждаться':
			guy += 1
			girl += 1
			gt'podrsex','var'
		end
	end
end
if $ARGS[0] = '3':
	$sexloc = $CURLOC
	cla
	*clr
	gs 'zz_render', '', 'images/img/centr/zal6.jpg', func('zal_strings', 'local_str7')
	act 'Послать':gt'fit','razd'
	act 'Флиртовать':
		cla
		*clr
		picrand = 12
		gs 'zz_render', '', 'images/img/centr/zal7.jpg', func('zal_strings', 'local_str8')
		act 'Уйти':gt'fit','razd'
		act 'Сосать':
			guy += 2
			girl += 1
			gang += 1
			xgt'sexdvanadva','var'
		end
	end
end