//
//  PwdGen.swift
//  PwdGenMac
//
//  Created by Вадим Курбский on 19.07.2024.
//

import Foundation

enum PwdGenModes {
    case UpperRussian,
    UpperEnglish,
    LowerRussian,
    LowerEnglish,
    Numbers, 
    Chars
}

class PwdGen {
    private let russianLetters: String = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
    private let englishLetters: String = "abcdefghijklmnopqrstuvwxyz";
    private let numbers: String = "0123456789";
    private let chars: String = "~!@#$%^&?*-=+_'`\"";
    private let dots: String = ",.:;-=_+";
    private let brackets: String = "(){}[]<>";
    private let slashes: String = "/|\\";

    private var vocabulary: [String]
 
    init() {
        vocabulary = [
            englishLetters,
            englishLetters.uppercased(),
            numbers,
            chars + dots + brackets + slashes
        ]
    }
    
    func SetMode(_ mode: Set<PwdGenModes>) {
        vocabulary = []
        if mode.contains(.UpperRussian) {
            vocabulary.append(russianLetters.uppercased())
        }
        if mode.contains(.UpperEnglish) {
            vocabulary.append(englishLetters.uppercased())
        }
        if mode.contains(.LowerRussian) {
            vocabulary.append(russianLetters)
        }
        if mode.contains(.LowerEnglish) {
            vocabulary.append(englishLetters)
        }
        if mode.contains(.Numbers) {
            vocabulary.append(numbers)
        }
        if mode.contains(.Chars) {
            vocabulary.append(chars + dots + brackets + slashes)
        }
    }
       
    func Generate(_ length: Int) -> String {
        var res = ""
        for _ in 0...length {
            let page = vocabulary[Int.random(in: 0..<vocabulary.count)]
            let off = page.index(page.startIndex, offsetBy: Int.random(in: 0..<page.count))
            res += page[off...off]
        }
        return res
    }
}
