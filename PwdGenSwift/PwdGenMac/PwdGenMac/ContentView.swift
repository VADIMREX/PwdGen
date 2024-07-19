//
//  ContentView.swift
//  PwdGenMac
//
//  Created by Вадим Курбский on 19.07.2024.
//

import SwiftUI


struct ContentView: View {
    var pwdGen: PwdGen;
    
    @State private var password: String = ""
    @State private var slength: String = "9"
    @State private var flength: Float = 9
    @State private var length: Int = 9
    @State private var isRussianUpper: Bool = false
    @State private var isEnglishUpper: Bool = true
    @State private var isRussianLower: Bool = false
    @State private var isEnglishLower: Bool = true
    @State private var isNumbers: Bool = true
    @State private var isCharacters: Bool = true
    
    init(pwdGen: PwdGen) {
        self.pwdGen = pwdGen
    }
    
    func generate() {
        var mode = Set<PwdGenModes>()
        if isRussianLower {
            mode.insert(.LowerRussian)
        }
        if isEnglishLower {
            mode.insert(.LowerEnglish)
        }
        if isRussianUpper {
            mode.insert(.UpperRussian)
        }
        if isEnglishUpper {
            mode.insert(.UpperEnglish)
        }
        if isNumbers {
            mode.insert(.Numbers)
        }
        if isCharacters {
            mode.insert(.Chars)
        }
        
        pwdGen.SetMode(mode)
        
        password = pwdGen.Generate(length)
    }
    
    func save() {
        
    }
    
    func exit() {
       
    }
    
    var body: some View {
        VStack{
            HStack {
                VStack {
                    TextField(
                        "",
                        text: $password
                    )
                    HStack{
                        Toggle("Заглавные русские буквы", isOn: $isRussianUpper)
                        Toggle("Строчные английские буквы", isOn: $isEnglishLower)
                        Toggle("Цифры", isOn: $isNumbers)
                        
                    }
                    HStack {
                        Toggle("Заглавные английчкие буквы", isOn: $isEnglishUpper)
                        Toggle("Строчные русские буквы", isOn: $isRussianLower)
                        Toggle("Символы", isOn: $isCharacters)
                    }
                }
                VStack{
                    Button(action: generate) {
                        Text("Генерировать")
                    }
                    Button(action: save) {
                        Text("Сохранить")
                    }
                    Button(action: exit) {
                        Text("Выход")
                    }
                }
            }
            HStack{
                HStack{
                    Text("Длинна пароля:")
                    TextField("", text: $slength){ _ in
                        let a =  Int(slength)
                        if a != nil {
                            length = a!
                            flength = Float(length)
                        }
                    }
                }
                Slider(
                    value: $flength,
                    in: 0...1000) { _ in
                        length = Int(flength)
                        slength = String(length)
                    }
            }
        }
        .padding()
    }
    
    
}

#Preview {
    ContentView(pwdGen: PwdGen())
}
