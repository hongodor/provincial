﻿! переменные ивентов Игоря Круглова:
! $npc['4,qwIgorMain'] - стадия ветки развращения Игоря
! $npc['4,day'] - флаг ивента, раз в день
! $npc['4,sex_day'] - флаг секса с Игорем, раз в день
! $npc['4,horny'] - возбужение Игоря(взависимости больше или меньше возбуждения ГГ влияет на секс с Игорем)
! $npc['4,no_orgasm'] - недовольстово ГГ от секса с Игорем(включает ветку развращения Игоря)
! $npc['4,strapon_sex'] - секс с Игорем со страпоном(влияет на ветку развращения Игоря))
! $npc['4,qwMeetDiana'] - ветка свиданий Круглова и Носова
!---
! ветка развращения Игоря, стадии
! 0 - ветка не начата
! 1 - при прогулке в парке Игорь упоминает свою сестру
! 2 - первая примерка одежды
! 3 - вторая примерка одежды
! 4 - первое переодевание Игоря в женскую одежду. Открывается возможность секса с ним в таком виде.
! 5,6 - прогулки с переодетым Игорем в парке
! 7 - прогулка с переодетым Игорем в парке, первая встреча с Носовым - начало ветки "Дианы"
! 8 - намёк на секс со страпоном
! 9 - пьянка с Игорем, его обещание согласиться на секс со страпоном
! 10 - первый секс со страпоном
! 11 - регулярный секс с Игорем со страпоном
! 12 - Игорь полностью развращен, "Диана" готова к свиданию
! ---------------
! ветка свиданий Круглова и Носова
! 0 - первая встреча ГГ и Игоря с Носовым в парке
! 1 - Носов просит организовать встречу с "Дианой"
! 2 - ГГ разговаривает с Игорем на счёт встречи с Носовым, Игорь отказывается
! 3 - ГГ передает Носову отказ от "Дианы", Носов просит просто вытянуть "Диану" в парк, а он "случайно" встретится сам
! 4 - вторая встреча ГГ и Игоря с Носовым в парке, Носов назначает "Диане" свидание.
! 5,6 - ГГ решает не уговаривать Игоря идти на свидание. Носов каждый день достаёт ГГ вопросами о "Диане"
! 7 - Игорь даёт согласие на свидание с Носовым, ГГ ему это передаёт
! 8 - Игорь идёт на свидание.
! 9 - если Игорь на свидании полностью развращён, он отсасывает Носову(конец ветки, продолжение следует)
! 10 - если Игорь на свидании не развращён, то Носов узнаёт "Диане" Игоря. После этого Носов ловит ГГ на улице и ставит перед выбором, либо ГГ занимает место "Дианы", либо он рассказывает всем про Игоря
! 11 - ГГ соглашается с условиями Носова, отношения с Игорем обнуляются
! 12 - ГГ не соглашается с условиями Носова. Игорь переводится в группу изгоев, отношения со всеми школьными НПС, кроме Сони и Носова, понижаются.
! ---------------
gs 'npc_editor','get_npc_profile',4
gs 'npc_editor','init_sex',4
act 'Поболтать':
	*clr & cla
	minut += 5
	gs 'npc_editor','get_npc_profile',4
	gs 'npc_editor','change_rep','+',4
	gs 'stat'
	$zz_str[0] = 'Вы болтаете о школе'
	$zz_str[1] = 'Вы беседуете о жизни после окончания школы'
	$zz_str[2] = 'Вы слушаете, как он рассказывает какую-то интересную историю'
	$zz_str[3] = 'Вы болтаете о всякой ерунде'
	$zz_str[4] = 'Вы разговариваете с ним. Игорь говорит, что родители пообещали купить ему машину, если он сможет поступить в универ.'
	$zz_str[5] = 'Вы из беседы с ним узнали, что у его родителей собственный бизнес и дома они бывают редко.'
	gs 'zz_render', '', '','Вы решили поболтать с Игорем.'+$zz_str[rand(0,5)]
	killvar '$zz_str'
	act 'Далее': gt 'igor'
end
if $npc['4,sex_day'] ! day:
	act 'Целоваться':
		*clr & cla
		$npc['4,sex_day'] = day
		minut += 5
		manna += 10
		horny += 10
		$npc['4,horny'] = rand(50,100)
		gs 'stat'
		gs 'zz_render', '', 'images/qwest/alter/kruglov/kiss.gif','Вы страстно целуетесь, он начинает мять вашу грудь, затем и гладить вашу промежность.\\\- <<$name[2]>>, я хочу тебя! Давай займёмся сексом... - ///шепчет он вам на ухо.'
		act'Согласиться': gt 'igor_events',iif($npc['4,qwIgorMain'] >= 11 and dom >= 50,'strapon_sex','sex')
		if horny < 90:
			if $npc['4,qwIgorMain'] < 4:
				act 'Остановить его':
					*clr & cla
					gs 'npc_editor','get_npc_profile',4
					gs 'zz_render', '', '', '\\\- Ну пожалуйста... -/// начал уговаривать Игорь.'
					if horny < 75:act 'Я сказала - НЕТ':dom += 1 & gt 'igor'
					act 'Ну ладно...': gt 'igor_events','sex'
				end
			end
			! секс с переодеванием
			if $npc['4,qwIgorMain'] >= 4 and $npc['4,qwIgorMain'] < 10 or $npc['4,qwIgorMain'] >= 11 and dom < 50: act'Предложить заняться сексом "по особому"': gt 'igor_events','krossdress_sex'
			! намек на страпон
			if $npc['4,qwIgorMain'] = 8: act 'Намекнуть': gt 'igor_events','strapon'
			! первый секс с страпоном
			if $npc['4,qwIgorMain'] = 10 and $npc['4,day'] ! day: act 'Напомнить об обещании': gt 'igor_events','first_strapon_sex'
		end
	end
end
if hour < 19:
	! прогулка в парке
	if $npc['4,qwIgorMain'] < 2 and $npc['4,day'] ! day: act 'Предложить погулять': gt 'igor_events','walk'
	! примерка #1
	if $npc['4,qwIgorMain'] = 2 and $npc['4,day'] ! day: act'Спросить про сестру': gt 'igor_events','talk_sister'
	! примерка #2
	if $npc['4,qwIgorMain'] = 3 and $npc['4,day'] ! day: act'Хочу померить одежду': gt 'igor_events','try_clothes'
	! первая прогулка с переодетым Игорем.
	if $npc['4,qwIgorMain'] = 4 and $npc['4,day'] ! day: act 'Я хочу видеть свою девочку!': gt 'igor_events','krossdress_walk1'
	! вторая прогулка с переодетым Игорем.
	if $npc['4,qwIgorMain'] = 5 and $npc['4,day'] ! day: act 'Прогуляемся?': gt 'igor_events','krossdress_walk2'
	! третья прогулка с переодетым Игорем.
	if $npc['4,qwIgorMain'] = 6 and $npc['4,day'] ! day: act 'Прогуляемся?': gt 'igor_events','krossdress_walk3'
	! четвёртая прогулка с переодетым Игорем.
	if $npc['4,qwMeetDiana'] = 4 and $npc['4,day'] ! day: act 'Прогуляемся?': gt 'igor_events','krossdress_walk4'
end
! пьянка и обещание Игоря
if $npc['4,qwIgorMain'] = 9 and wine = 1 and $npc['4,day'] ! day: act 'Выпить вина с Игорем': gt 'igor_events','drink'
! диалог после разговора с Носовым
if $npc['4,qwMeetDiana'] = 2: act 'Сказать про Диму': gt 'igor_events','meet_diana1'
! диалог по поводу свидания с Носовым
if $npc['4,qwMeetDiana'] = 6: act 'Спросить про Диму': gt 'igor_events','meet_diana2'
! рассказ Игоря о свидании с Носовым в выходные
if $npc['4,qwMeetDiana'] = 8 and $npc['4,date_day'] < daystart:
	cla
	act 'Узнать как прошло свидание': gt 'igor_events','weekend'
end
if hour = 20:
	*clr & cla
	gs 'npc_editor','get_npc_profile',4
	gs 'zz_render', '', '','Игорь смотрит на часы:**\\\ - <<$name[2]>>, Пойдёшь на дискотеку?///'
	act 'Идти с Игорем': & minut += 20 & gt 'gdkin'
	act 'Попрощаться и идти домой': gt 'gorodok'
end
if hour < 6:
	*clr & cla
	gs 'npc_editor','get_npc_profile',4
	gs 'zz_render', '', '','Вы посмотрели на часы и сказали, что вам пора домой.'
	act 'Попрощаться и идти домой': gt 'gorodok'
end
act '<B>Отойти</B>': gt 'igorHome', 'igorkom'