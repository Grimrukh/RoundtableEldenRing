sub rsp,48
mov edi,[0x{0:X2}]   ;runeAmountAddr
mov rcx,0x{1:X2}     ;WorldChrMan
mov rcx,[rcx+0x10EF8]
mov rcx,[rcx]
mov rcx,[rcx+0x580]
mov edx,edi
call 0x{2:X2}         ;GetRunes_Call   
add rsp,48
ret