package main

import (
	"fmt"
	"os"
	"pwdgen/pwdgen"
	"strconv"
)

func main() {
	var err error
	pwdLen := 9
	if len(os.Args) > 1 {
		pwdLen, err = strconv.Atoi(os.Args[1])
		if err != nil {
			pwdLen = 9
		}
	}
	pwd := pwdgen.PwdVocabulary{
		pwdgen.Numbers,
		pwdgen.LowerEnglishLetters,
		pwdgen.Brackets,
		pwdgen.UpperEnglishLetters,
		pwdgen.Chars,
		pwdgen.LowerEnglishLetters,
		pwdgen.Dots,
		pwdgen.UpperEnglishLetters,
		pwdgen.Numbers,
	}.Generate(pwdLen)
	fmt.Println(pwd)
}
