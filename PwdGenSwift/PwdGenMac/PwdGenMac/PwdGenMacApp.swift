//
//  PwdGenMacApp.swift
//  PwdGenMac
//
//  Created by Вадим Курбский on 19.07.2024.
//

import SwiftUI

@main
struct PwdGenMacApp: App {
    var body: some Scene {
        WindowGroup  {
            ContentView(pwdGen: PwdGen())
            
        }
    }
}
