package pwdgen

import (
	"math/rand"
)

const (
	LowerRussianLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"
	LowerEnglishLetters = "abcdefghijklmnopqrstuvwxyz"
	UpperRussianLetters = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"
	UpperEnglishLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
	Numbers             = "0123456789"
	Chars               = "~!@#$%^&?*-=+_'`\""
	Dots                = ",.:;-=_+"
	Brackets            = "(){}[]<>"
	Slashes             = "/|\\"
)

type PwdVocabulary []string

func (vocab PwdVocabulary) Generate(pwdlen int) string {
	pwd := make([]rune, pwdlen)

	for i := range pwd {
		v := []rune(vocab[rand.Intn(len(vocab))])
		pwd[i] = v[rand.Intn(len(v))]
	}

	return string(pwd)
}
