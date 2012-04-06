@echo off

@attrib -r -a -s -h /s
@for /r %%x in (*.user;*.scc;*.suo;*.ncb;StyleCop.Cache) do (
	@echo %%x
	@del "%%x"
)

@attrib -r -a -s -h /s
@for /r %%x in (bin;obj) do (
	@echo %%x
	@rmdir /s /q "%%x"
)

pause

