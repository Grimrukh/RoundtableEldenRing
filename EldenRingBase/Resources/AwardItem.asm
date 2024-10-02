mov eax,0x{0:X2}                  ;ItemCategory * 0x1000_0000
sub rsp,0x40
xor r9d,r9d                     ;display type
mov r15d,[0x{2:X2}]          ;ItemSpawnData + 4
add [0x{2:X2}],eax           ;ItemSpawnData + 4
lea rdx,[0x{1:X2}]              ;ItemSpawnData + 0 (always 1)
lea r8,[0x{3:X2}]           ;ItemSpawnData + 0xC (always 0xFFFFFFFF, probably was durability)
mov rcx,0x{4:X2}                ;MapItemMan
push r15
call 0x{5:X2}                   ;AwardItemFunc
pop r15
mov [0x{2:X2}],r15d          ;ItemSpawnData + 4
add rsp,0x40
ret
