import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HoaDonChiTietComponent } from './hoa-don-chi-tiet.component';

describe('HoaDonChiTietComponent', () => {
  let component: HoaDonChiTietComponent;
  let fixture: ComponentFixture<HoaDonChiTietComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HoaDonChiTietComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HoaDonChiTietComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
