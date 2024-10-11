import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucDuAnComponent } from './danh-muc-du-an.component';

describe('DanhMucDuAnComponent', () => {
  let component: DanhMucDuAnComponent;
  let fixture: ComponentFixture<DanhMucDuAnComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucDuAnComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucDuAnComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
