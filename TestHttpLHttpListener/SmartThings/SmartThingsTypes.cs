
namespace TestHttpLHttpListener.SmartThings
{
    public enum SmartThingsTypes
    {
        None,
        /// <summary>
        /// Лампочка, светильник, ночник, люстра.
        /// </summary>
        Light,
        /// <summary>
        /// Умная розетка.
        /// </summary>
        Socket,
        /// <summary>
        /// Настенный выключатель света, тумблер, автомат в электрическом щитке, умное реле, умная кнопка.
        /// </summary>
        Switch,
        /// <summary>
        /// Водонагреватель, теплый пол, обогреватель, электровентилятор.
        /// </summary>
        Thermostat,
        /// <summary>
        /// Кондиционер.
        /// </summary>
        ThermostatAc,
        /// <summary>
        /// DVD-плеер и другие медиаустройства. 
        /// </summary>
        MediaDevice,
        /// <summary>
        /// Умный телевизор, ИК-пульт от телевизора, медиаприставка, ресивер.
        /// </summary>
        MediaDeviceTv,
        /// <summary>
        /// ИК-пульт от ТВ-приставки, умная ТВ-приставка.
        /// </summary>
        MediaDeviceTvBox,
        /// <summary>
        /// ИК-пульт от ресивера, AV-ресивер, спутниковый ресивер.
        /// </summary>
        MediaDeviceReceiver,
        /// <summary>
        /// Холодильник, духовой шкаф, кофеварка, мультиварка.
        /// </summary>
        Cooking,
        /// <summary>
        /// Кофеварка, кофемашина.
        /// </summary>
        CookingCoffeeMaker,
        /// <summary>
        /// Умный чайник, термопот.
        /// </summary>
        CookingKettle,
        /// <summary>
        /// Мультиварка.
        /// </summary>
        CookingMulticooker,
        /// <summary>
        /// Дверь, ворота, окно, ставни. 
        /// </summary>
        Openable,
        /// <summary>
        /// Шторы, жалюзи.
        /// </summary>
        OpenableCurtain,
        /// <summary>
        /// Увлажнитель воздуха.
        /// </summary>
        Humidifier,
        /// <summary>
        /// Очиститель воздуха, мойка воздуха.
        /// </summary>
        Purifier,
        /// <summary>
        /// Робот-пылесос.
        /// </summary>
        VacuumCleaner,
        /// <summary>
        /// Стиральная машина.
        /// </summary>
        WashingMachine,
        /// <summary>
        /// Посудомоечная машина.
        /// </summary>
        Dishwasher,
        /// <summary>
        /// Утюг, парогенератор.
        /// </summary>
        Iron,
        /// <summary>
        /// Датчик температуры, датчик влажности, датчик открытия двери, датчик движения.
        /// </summary>
        Sensor,
        /// <summary>
        /// Остальные устройства, не подходящие под типы выше.
        /// </summary>
        Other
    }
}
