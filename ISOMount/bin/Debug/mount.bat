@echo off

set string="%1 %2 %3"
echo string = %string%

powershell -command %string%