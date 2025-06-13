# Global soft reset control [R/W]
dut.write(0x0, 0x0)

# Global request and mode control [R/W]
dut.write(0x1, 0x0)

# Global request and mode control [R/W]
dut.write(0x2, 0x0)

# Global enable control [R/W]
dut.write(0x3, 0x17)

# Global enable control [R/W]
dut.write(0x4, 0x6F)

# Global mode and enable control [R/W]
dut.write(0x5, 0x88)

# Global clear alarms [R/W]
dut.write(0x6, 0x0)

# Global miscellaneous control [R/W]
dut.write(0x7, 0x0)

# Global miscellaneous control [R/W]
dut.write(0x8, 0x0)

# Global miscellaneous control [R/W]
dut.write(0x9, 0x1)

# CLKIN0/CLKIN0 input buffer control [R/W]
dut.write(0xA, 0x0)

# CLKIN1/CLKIN1 input buffer control [R/W]
dut.write(0xB, 0x0)

# CLKIN2/CLKIN2 input buffer control [R/W]
dut.write(0xC, 0x0)

# CLKIN3/CLKIN3 input buffer control [R/W]
dut.write(0xD, 0x1)

# OSCIN/OSCIN input buffer control [R/W]
dut.write(0xE, 0xB)

# PLL1 reference priority control [R/W]
dut.write(0x14, 0x93)

# PLL1 loss of signal (LOS) control [R/W]
dut.write(0x15, 0x3)

# PLL1 holdover exit control [R/W]
dut.write(0x16, 0x4)

# PLL1 holdover DAC/ADC control [R/W]
dut.write(0x17, 0x0)

# PLL1 holdover DAC/ADC control [R/W]
dut.write(0x18, 0x4)

# PLL1 LOS mode control [R/W]
dut.write(0x19, 0x0)

# PLL1 charge pump control [R/W]
dut.write(0x1A, 0x7)

# PLL1 PFD control [R/W]
dut.write(0x1B, 0x18)

# CLKIN0/CLKIN0 input prescaler control [R/W]
dut.write(0x1C, 0x1)

# CLKIN1/CLKIN1 input prescaler control [R/W]
dut.write(0x1D, 0x1)

# CLKIN2/CLKIN2 input prescaler control [R/W]
dut.write(0x1E, 0x1)

# CLKIN3/CLKIN3 input prescaler control [R/W]
dut.write(0x1F, 0x1)

# OSCIN/OSCIN Input prescaler control [R/W]
dut.write(0x20, 0x1)

# PLL1 reference divider control (R1)  LSB [R/W]
dut.write(0x21, 0x8)

# PLL1 reference divider control (R1) MSB [R/W]
dut.write(0x22, 0x0)

# PLL1 feedback divider control (N1) LSB [R/W]
dut.write(0x26, 0x8)

# PLL1 feedback divider control (N1)  MSB [R/W]
dut.write(0x27, 0x0)

# PLL1 lock detect control [R/W]
dut.write(0x28, 0xF)

# PLL1 reference switching control [R/W]
dut.write(0x29, 0x1C)

# PLL1 holdoff time control [R/W]
dut.write(0x2A, 0x0)

# PLL2 miscellaneous control [R/W]
dut.write(0x31, 0x1)

# PLL2 frequency doubler control [R/W]
dut.write(0x32, 0x1)

# PLL2 reference divider control (R2) LSB [R/W]
dut.write(0x33, 0xA)

# PLL2 reference divider control (R2) MSB [R/W]
dut.write(0x34, 0x0)

# PLL2 feedback divider control (N2) LSB [R/W]
dut.write(0x35, 0xE1)

# PLL2 feedback divider control (N2) MSB [R/W]
dut.write(0x36, 0x0)

# PLL2 charge pump control [R/W]
dut.write(0x37, 0xF)

# PLL2 PFD control [R/W]
dut.write(0x38, 0x18)

# OSCOUTx/ OSCOUTx path control [R/W]
dut.write(0x39, 0x1)

# OSCOUTx/ OSCOUTx driver control [R/W]
dut.write(0x3A, 0x21)

# OSCOUTx/ OSCOUTx driver control [R/W]
dut.write(0x3B, 0x0)

# PLL2 miscellaneous control [R/W]
dut.write(0x3C, 0x0)

# GPI1 control [R/W]
dut.write(0x46, 0x0)

# GPI2 control [R/W]
dut.write(0x47, 0x0)

# GPI3 control [R/W]
dut.write(0x48, 0x9)

# GPI4 control [R/W]
dut.write(0x49, 0x0)

# GPO1 control [R/W]
dut.write(0x50, 0x1F)

# GPO2 control [R/W]
dut.write(0x51, 0x2B)

# GPO3 control [R/W]
dut.write(0x52, 0x0)

# GPO4 control [R/W]
dut.write(0x53, 0x0)

# SDATA control [R/W]
dut.write(0x54, 0x3)

# Pulse generator control [R/W]
dut.write(0x5A, 0x0)

# SYNC control [R/W]
dut.write(0x5B, 0x6)

# SYSREF timer control LSB [R/W]
dut.write(0x5C, 0xE8)

# SYSREF timer control MSB [R/W]
dut.write(0x5D, 0x3)

# SYSREF miscellaneous control [R/W]
dut.write(0x5E, 0x0)

# External VCO control [R/W]
dut.write(0x64, 0x0)

# Analog delay common control [R/W]
dut.write(0x65, 0x0)

# PLL1 alarm mask control [R/W]
dut.write(0x70, 0x0)

# Alarm mask control [R/W]
dut.write(0x71, 0x10)

# Product ID LSB [R]
dut.write(0x78, 0x51)

# Product ID MID [R]
dut.write(0x79, 0x52)

# Product ID MSB [R]
dut.write(0x7A, 0x30)

# Readback register [R]
dut.write(0x7B, 0x1)

# PLL1 alarm readback [R]
dut.write(0x7C, 0x1F)

# Alarm readback [R]
dut.write(0x7D, 0x1B)

# Latched alarm readback [R]
dut.write(0x7E, 0x7F)

# Alarm readback miscellaneous [R]
dut.write(0x7F, 0x0)

# PLL1 status registers [R]
dut.write(0x82, 0x4)

# PLL1 status registers [R]
dut.write(0x83, 0x4C)

# PLL1 status registers [R]
dut.write(0x84, 0x4C)

# PLL1 status registers [R]
dut.write(0x85, 0xA)

# PLL1 status registers [R]
dut.write(0x86, 0x0)

# PLL1 status registers [R]
dut.write(0x87, 0x4)

# PLL2 status registers [R]
dut.write(0x8C, 0xE)

# PLL2 status registers [R]
dut.write(0x8D, 0x2)

# PLL2 status registers [R]
dut.write(0x8E, 0x0)

# PLL2 status registers [R]
dut.write(0x8F, 0x0)

# PLL2 status registers [R]
dut.write(0x90, 0x0)

# SYSREF status register [R]
dut.write(0x91, 0x2)

# Reserved [R/W]
dut.write(0x96, 0x0)

# Reserved [R/W]
dut.write(0x97, 0x0)

# Reserved [R/W]
dut.write(0x98, 0x0)

# Reserved [R/W]
dut.write(0x99, 0x0)

# Reserved [R/W]
dut.write(0x9A, 0x0)

# Reserved [R/W]
dut.write(0x9B, 0xAA)

# Reserved [R/W]
dut.write(0x9C, 0xAA)

# Reserved [R/W]
dut.write(0x9D, 0xAA)

# Reserved [R/W]
dut.write(0x9E, 0xAA)

# Reserved [R/W]
dut.write(0x9F, 0x4D)

# Reserved [R/W]
dut.write(0xA0, 0xDF)

# Reserved [R/W]
dut.write(0xA1, 0x97)

# Reserved [R/W]
dut.write(0xA2, 0x3)

# Reserved [R/W]
dut.write(0xA3, 0x0)

# Reserved [R/W]
dut.write(0xA4, 0x0)

# Reserved [R/W]
dut.write(0xA5, 0x6)

# Reserved [R/W]
dut.write(0xA6, 0x1C)

# Reserved [R/W]
dut.write(0xA7, 0x0)

# Reserved [R/W]
dut.write(0xA8, 0x6)

# Reserved [R/W]
dut.write(0xA9, 0x0)

# Reserved [R/W]
dut.write(0xAB, 0x0)

# Reserved [R/W]
dut.write(0xAC, 0x20)

# Reserved [R/W]
dut.write(0xAD, 0x0)

# Reserved [R/W]
dut.write(0xAE, 0x8)

# Reserved [R/W]
dut.write(0xAF, 0x50)

# Reserved [R/W]
dut.write(0xB0, 0x4)

# Reserved [R/W]
dut.write(0xB1, 0xD)

# Reserved [R/W]
dut.write(0xB2, 0x0)

# Reserved [R/W]
dut.write(0xB3, 0x0)

# Reserved [R/W]
dut.write(0xB5, 0x0)

# Reserved [R/W]
dut.write(0xB6, 0x0)

# Reserved [R/W]
dut.write(0xB7, 0x0)

# Reserved [R/W]
dut.write(0xB8, 0x0)

# Channel Output 0 control [R/W]
dut.write(0xC8, 0x71)

# Channel Output 0 control [R/W]
dut.write(0xC9, 0x48)

# Channel Output 0 control [R/W]
dut.write(0xCA, 0x0)

# Channel Output 0 control [R/W]
dut.write(0xCB, 0x0)

# Channel Output 0 control [R/W]
dut.write(0xCC, 0x0)

# Channel Output 0 control [R/W]
dut.write(0xCD, 0x0)

# Channel Output 0 control [R/W]
dut.write(0xCE, 0x0)

# Channel Output 0 control [R/W]
dut.write(0xCF, 0x0)

# Channel Output 0 control [R/W]
dut.write(0xD0, 0x10)

# Channel Output 0 control [R/W]
dut.write(0xD1, 0x0)

# Channel Output 1 control [R/W]
dut.write(0xD2, 0x71)

# Channel Output 1 control [R/W]
dut.write(0xD3, 0x20)

# Channel Output 1 control [R/W]
dut.write(0xD4, 0x1)

# Channel Output 1 control [R/W]
dut.write(0xD5, 0x0)

# Channel Output 1 control [R/W]
dut.write(0xD6, 0x0)

# Channel Output 1 control [R/W]
dut.write(0xD7, 0x0)

# Channel Output 1 control [R/W]
dut.write(0xD8, 0x0)

# Channel Output 1 control [R/W]
dut.write(0xD9, 0x0)

# Channel Output 1 control [R/W]
dut.write(0xDA, 0x11)

# Channel Output 1 control [R/W]
dut.write(0xDB, 0x0)

# Channel Output 2 control [R/W]
dut.write(0xDC, 0x71)

# Channel Output 2 control [R/W]
dut.write(0xDD, 0x48)

# Channel Output 2 control [R/W]
dut.write(0xDE, 0x0)

# Channel Output 2 control [R/W]
dut.write(0xDF, 0x0)

# Channel Output 2 control [R/W]
dut.write(0xE0, 0x3)

# Channel Output 2 control [R/W]
dut.write(0xE1, 0x0)

# Channel Output 2 control [R/W]
dut.write(0xE2, 0x0)

# Channel Output 2 control [R/W]
dut.write(0xE3, 0x0)

# Channel Output 2 control [R/W]
dut.write(0xE4, 0x10)

# Channel Output 2 control [R/W]
dut.write(0xE5, 0x0)

# Channel Output 3 control [R/W]
dut.write(0xE6, 0x71)

# Channel Output 3 control [R/W]
dut.write(0xE7, 0x20)

# Channel Output 3 control [R/W]
dut.write(0xE8, 0x1)

# Channel Output 3 control [R/W]
dut.write(0xE9, 0x0)

# Channel Output 3 control [R/W]
dut.write(0xEA, 0x3)

# Channel Output 3 control [R/W]
dut.write(0xEB, 0x0)

# Channel Output 3 control [R/W]
dut.write(0xEC, 0x0)

# Channel Output 3 control [R/W]
dut.write(0xED, 0x0)

# Channel Output 3 control [R/W]
dut.write(0xEE, 0x11)

# Channel Output 3 control [R/W]
dut.write(0xEF, 0x0)

# Channel Output 4 control [R/W]
dut.write(0xF0, 0x70)

# Channel Output 4 control [R/W]
dut.write(0xF1, 0x48)

# Channel Output 4 control [R/W]
dut.write(0xF2, 0x0)

# Channel Output 4 control [R/W]
dut.write(0xF3, 0x3)

# Channel Output 4 control [R/W]
dut.write(0xF4, 0x0)

# Channel Output 4 control [R/W]
dut.write(0xF5, 0x0)

# Channel Output 4 control [R/W]
dut.write(0xF6, 0x0)

# Channel Output 4 control [R/W]
dut.write(0xF7, 0x0)

# Channel Output 4 control [R/W]
dut.write(0xF8, 0x10)

# Channel Output 4 control [R/W]
dut.write(0xF9, 0x0)

# Channel Output 5 control [R/W]
dut.write(0xFA, 0x7C)

# Channel Output 5 control [R/W]
dut.write(0xFB, 0x20)

# Channel Output 5 control [R/W]
dut.write(0xFC, 0x1)

# Channel Output 5 control [R/W]
dut.write(0xFD, 0x0)

# Channel Output 5 control [R/W]
dut.write(0xFE, 0x0)

# Channel Output 5 control [R/W]
dut.write(0xFF, 0x0)

# Channel Output 5 control [R/W]
dut.write(0x100, 0x0)

# Channel Output 5 control [R/W]
dut.write(0x101, 0x0)

# Channel Output 5 control [R/W]
dut.write(0x102, 0x13)

# Channel Output 5 control [R/W]
dut.write(0x103, 0x0)

# Channel Output 6 control [R/W]
dut.write(0x104, 0x70)

# Channel Output 6 control [R/W]
dut.write(0x105, 0x48)

# Channel Output 6 control [R/W]
dut.write(0x106, 0x0)

# Channel Output 6 control [R/W]
dut.write(0x107, 0x0)

# Channel Output 6 control [R/W]
dut.write(0x108, 0x0)

# Channel Output 6 control [R/W]
dut.write(0x109, 0x0)

# Channel Output 6 control [R/W]
dut.write(0x10A, 0x0)

# Channel Output 6 control [R/W]
dut.write(0x10B, 0x0)

# Channel Output 6 control [R/W]
dut.write(0x10C, 0x10)

# Channel Output 6 control [R/W]
dut.write(0x10D, 0x0)

# Channel Output 7 control [R/W]
dut.write(0x10E, 0x7C)

# Channel Output 7 control [R/W]
dut.write(0x10F, 0x20)

# Channel Output 7 control [R/W]
dut.write(0x110, 0x1)

# Channel Output 7 control [R/W]
dut.write(0x111, 0x0)

# Channel Output 7 control [R/W]
dut.write(0x112, 0x0)

# Channel Output 7 control [R/W]
dut.write(0x113, 0x0)

# Channel Output 7 control [R/W]
dut.write(0x114, 0x0)

# Channel Output 7 control [R/W]
dut.write(0x115, 0x0)

# Channel Output 7 control [R/W]
dut.write(0x116, 0x13)

# Channel Output 7 control [R/W]
dut.write(0x117, 0x0)

# Channel Output 8 control [R/W]
dut.write(0x118, 0x70)

# Channel Output 8 control [R/W]
dut.write(0x119, 0x48)

# Channel Output 8 control [R/W]
dut.write(0x11A, 0x0)

# Channel Output 8 control [R/W]
dut.write(0x11B, 0x0)

# Channel Output 8 control [R/W]
dut.write(0x11C, 0x0)

# Channel Output 8 control [R/W]
dut.write(0x11D, 0x0)

# Channel Output 8 control [R/W]
dut.write(0x11E, 0x0)

# Channel Output 8 control [R/W]
dut.write(0x11F, 0x0)

# Channel Output 8 control [R/W]
dut.write(0x120, 0x10)

# Channel Output 8 control [R/W]
dut.write(0x121, 0x0)

# Channel Output 9 control [R/W]
dut.write(0x122, 0x7C)

# Channel Output 9 control [R/W]
dut.write(0x123, 0x20)

# Channel Output 9 control [R/W]
dut.write(0x124, 0x1)

# Channel Output 9 control [R/W]
dut.write(0x125, 0x0)

# Channel Output 9 control [R/W]
dut.write(0x126, 0x0)

# Channel Output 9 control [R/W]
dut.write(0x127, 0x0)

# Channel Output 9 control [R/W]
dut.write(0x128, 0x0)

# Channel Output 9 control [R/W]
dut.write(0x129, 0x0)

# Channel Output 9 control [R/W]
dut.write(0x12A, 0x13)

# Channel Output 9 control [R/W]
dut.write(0x12B, 0x0)

# Channel Output 10 control [R/W]
dut.write(0x12C, 0x71)

# Channel Output 10 control [R/W]
dut.write(0x12D, 0x48)

# Channel Output 10 control [R/W]
dut.write(0x12E, 0x0)

# Channel Output 10 control [R/W]
dut.write(0x12F, 0x0)

# Channel Output 10 control [R/W]
dut.write(0x130, 0x0)

# Channel Output 10 control [R/W]
dut.write(0x131, 0x0)

# Channel Output 10 control [R/W]
dut.write(0x132, 0x0)

# Channel Output 10 control [R/W]
dut.write(0x133, 0x0)

# Channel Output 10 control [R/W]
dut.write(0x134, 0x10)

# Channel Output 10 control [R/W]
dut.write(0x135, 0x0)

# Channel Output 11 control [R/W]
dut.write(0x136, 0x7D)

# Channel Output 11 control [R/W]
dut.write(0x137, 0x20)

# Channel Output 11 control [R/W]
dut.write(0x138, 0x1)

# Channel Output 11 control [R/W]
dut.write(0x139, 0x0)

# Channel Output 11 control [R/W]
dut.write(0x13A, 0x0)

# Channel Output 11 control [R/W]
dut.write(0x13B, 0x0)

# Channel Output 11 control [R/W]
dut.write(0x13C, 0x0)

# Channel Output 11 control [R/W]
dut.write(0x13D, 0x0)

# Channel Output 11 control [R/W]
dut.write(0x13E, 0x11)

# Channel Output 11 control [R/W]
dut.write(0x13F, 0x0)

# Channel Output 12 control [R/W]
dut.write(0x140, 0x71)

# Channel Output 12 control [R/W]
dut.write(0x141, 0x48)

# Channel Output 12 control [R/W]
dut.write(0x142, 0x0)

# Channel Output 12 control [R/W]
dut.write(0x143, 0x0)

# Channel Output 12 control [R/W]
dut.write(0x144, 0x0)

# Channel Output 12 control [R/W]
dut.write(0x145, 0x0)

# Channel Output 12 control [R/W]
dut.write(0x146, 0x0)

# Channel Output 12 control [R/W]
dut.write(0x147, 0x0)

# Channel Output 12 control [R/W]
dut.write(0x148, 0x10)

# Channel Output 12 control [R/W]
dut.write(0x149, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x14A, 0x7D)

# Channel Output 13 control [R/W]
dut.write(0x14B, 0x20)

# Channel Output 13 control [R/W]
dut.write(0x14C, 0x1)

# Channel Output 13 control [R/W]
dut.write(0x14D, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x14E, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x14F, 0x1)

# Channel Output 13 control [R/W]
dut.write(0x150, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x151, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x152, 0x13)

# Channel Output 13 control [R/W]
dut.write(0x153, 0x0)

# Channel Output 13 control [R/W]
dut.write(0xC, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x14D, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x14E, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x14F, 0x1)

# Channel Output 13 control [R/W]
dut.write(0x150, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x151, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x152, 0x13)

# Channel Output 13 control [R/W]
dut.write(0x153, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x4D, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x14E, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x14F, 0x1)

# Channel Output 13 control [R/W]
dut.write(0x150, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x151, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x152, 0x13)

# Channel Output 13 control [R/W]
dut.write(0x153, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x4D, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x14E, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x14F, 0x1)

# Channel Output 13 control [R/W]
dut.write(0x150, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x151, 0x0)

# Channel Output 13 control [R/W]
dut.write(0x152, 0x13)

# Channel Output 13 control [R/W]
dut.write(0x153, 0x0)
