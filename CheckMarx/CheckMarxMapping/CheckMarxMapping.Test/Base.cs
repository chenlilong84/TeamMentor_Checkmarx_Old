﻿using System.Collections.Generic;

namespace CheckMarxMapping.Test
{
    public class Base
    {
        protected List<DataItem> GetData()
        {
            var dataList = new List<DataItem>
                {
                    new DataItem {QueryId = -517, Guid = "fa554526-0e27-470f-ba6c-464c2250cfbd"},
                    new DataItem {QueryId = -505, Guid = "1a7d87d3-eee8-4f1c-ab46-7aec1b5479fb"},
                    new DataItem {QueryId = -587, Guid = "2e03d087-3614-4927-8d20-d9efc3f7bbc4"},
                    new DataItem {QueryId = -588, Guid = "2e03d087-3614-4927-8d20-d9efc3f7bbc4"},
                    new DataItem {QueryId = -590, Guid = "418cfb77-5d0a-4fd9-9825-1732cf40070d"},
                    new DataItem {QueryId = -594, Guid = "c92edd0d-f59a-4dd5-bed3-48a2190c895f"},
                    new DataItem {QueryId = -591, Guid = "e1066fc2-22e3-47b3-ac0d-34a6fa70da68"},
                    new DataItem {QueryId = -1063, Guid = "e1066fc2-22e3-47b3-ac0d-34a6fa70da68"},
                    new DataItem {QueryId = -595, Guid = "e1066fc2-22e3-47b3-ac0d-34a6fa70da68"},
                    new DataItem {QueryId = -593, Guid = "c92edd0d-f59a-4dd5-bed3-48a2190c895f"},
                    new DataItem {QueryId = -610, Guid = "ac9e0d29-dfd0-4671-98f5-7106e6505c24"},
                    new DataItem {QueryId = -618, Guid = "fd5e30e7-1584-4417-8f00-a0f363ecb3c0"},
                    new DataItem {QueryId = -609, Guid = "59f42764-e58b-4695-962f-5efdf1f36bd6"},
                    new DataItem {QueryId = -622, Guid = "066bf23c-37c9-4bff-9ab9-5fa9bd59449b"},
                    new DataItem {QueryId = -599, Guid = "0cd0323c-88b1-4b26-87b8-f0e6bc30a47e"},
                    new DataItem {QueryId = -604, Guid = "d18c00d5-2365-45c8-bde7-0e189f812ff6"},
                    new DataItem {QueryId = -620, Guid = "79aaa6c6-54bd-4a98-9649-77f81312085e"},
                    new DataItem {QueryId = -634, Guid = "ba8a22a6-6b90-4cec-8826-7ad6258814b8"},
                    new DataItem {QueryId = -627, Guid = "3eb97a46-1f72-4cb3-9695-7cad04333206"},
                    new DataItem {QueryId = -632, Guid = "1d41e495-bd7d-4961-8dd7-7d4cfaa37814"},
                    new DataItem {QueryId = -648, Guid = "f4f6aab8-f22e-4189-98bd-0a879cdedc40"},
                    new DataItem {QueryId = -626, Guid = "e1066fc2-22e3-47b3-ac0d-34a6fa70da68"},
                    new DataItem {QueryId = -625, Guid = "e1066fc2-22e3-47b3-ac0d-34a6fa70da68"},
                    new DataItem {QueryId = -629, Guid = "468c8d7a-ffc6-49ad-bef5-1886fd809a96"},
                    new DataItem {QueryId = -638, Guid = "db479b30-f48e-4d2f-94f7-8fc050021021"},
                    new DataItem {QueryId = -1220, Guid = "e1066fc2-22e3-47b3-ac0d-34a6fa70da68"},
                    new DataItem {QueryId = -1065, Guid = "c92edd0d-f59a-4dd5-bed3-48a2190c895f"},
                    new DataItem {QueryId = -1060, Guid = "e1066fc2-22e3-47b3-ac0d-34a6fa70da68"},
                    new DataItem {QueryId = -1219, Guid = "db479b30-f48e-4d2f-94f7-8fc050021021"},
                    new DataItem {QueryId = -1061, Guid = "e1066fc2-22e3-47b3-ac0d-34a6fa70da68"},
                    new DataItem {QueryId = -580, Guid = "c92edd0d-f59a-4dd5-bed3-48a2190c895f"},
                    new DataItem {QueryId = -586, Guid = "f4f6aab8-f22e-4189-98bd-0a879cdedc40"},
                    new DataItem {QueryId = -583, Guid = "db479b30-f48e-4d2f-94f7-8fc050021021"},
                    new DataItem {QueryId = -581, Guid = "e1066fc2-22e3-47b3-ac0d-34a6fa70da68"},
                    new DataItem {QueryId = -584, Guid = "c92edd0d-f59a-4dd5-bed3-48a2190c895f"},
                    new DataItem {QueryId = -353, Guid = "fb0341e3-41c2-43bc-99d4-d12a037c1edd"},
                    new DataItem {QueryId = -361, Guid = "099d9a5b-3ac2-4acb-9192-5b6d7fafda34"},
                    new DataItem {QueryId = -423, Guid = "96d8cd55-3e74-4e26-a1b7-62189556df0c"},
                    new DataItem {QueryId = -424, Guid = "ea00a8ee-1248-42b5-9954-439a93fb14d8"},
                    new DataItem {QueryId = -425, Guid = "a86e3035-578c-4dfe-a147-2776af6de6e1"},
                    new DataItem {QueryId = -426, Guid = "26cf3a5c-3bbd-4239-b74f-f776df950ac8"},
                    new DataItem {QueryId = -430, Guid = "bc7538f2-9ef5-4ee2-86b8-ed3ca83fd971"},
                    new DataItem {QueryId = -427, Guid = "937f2173-5e39-48b6-bb3a-ecfd8f052bb0"},
                    new DataItem {QueryId = -431, Guid = "df8905a5-7e58-4c42-a39d-8123601477d7"},
                    new DataItem {QueryId = -432, Guid = "df8905a5-7e58-4c42-a39d-8123601477d7"},
                    new DataItem {QueryId = -429, Guid = "bc7538f2-9ef5-4ee2-86b8-ed3ca83fd971"},
                    new DataItem {QueryId = -433, Guid = "9da2fccb-d20c-4e74-9f59-349d799e25cf"},
                    new DataItem {QueryId = -468, Guid = "ee22e5e0-0953-4276-b0e6-955becda5ee8"},
                    new DataItem {QueryId = -471, Guid = "e3330147-aa23-4c8b-b7e8-51fdab57e7b4"},
                    new DataItem {QueryId = -479, Guid = "df8905a5-7e58-4c42-a39d-8123601477d7"},
                    new DataItem {QueryId = -483, Guid = "36d0c6a6-8a5c-4586-b0d5-917a9aff9557"},
                    new DataItem {QueryId = -469, Guid = "bbe58089-1a45-458f-81d2-12ad6c3c797c"},
                    new DataItem {QueryId = -470, Guid = "e2c41ebb-f288-4a3d-a901-360be6e630f5"},
                    new DataItem {QueryId = -463, Guid = "df8905a5-7e58-4c42-a39d-8123601477d7"},
                    new DataItem {QueryId = -464, Guid = "1fd3358c-722f-4e61-899f-26b7818b940c"},
                    new DataItem {QueryId = -466, Guid = "64071685-f105-4cf1-8196-b2599d534d46"},
                    new DataItem {QueryId = -474, Guid = "64071685-f105-4cf1-8196-b2599d534d46"},
                    new DataItem {QueryId = -449, Guid = "9a44e0a4-823a-4d99-90fb-7de648a094c8"},
                    new DataItem {QueryId = -441, Guid = "0cc358fe-0396-4142-bab5-ad327920b340"},
                    new DataItem {QueryId = -450, Guid = "baf9e37f-ae0c-4f38-99d4-1942aaefef44"},
                    new DataItem {QueryId = -435, Guid = "97b5eafb-970d-4436-ae7f-3141f057e410"},
                    new DataItem {QueryId = -460, Guid = "e724620c-b128-403f-b1a0-e9261c8375e6"},
                    new DataItem {QueryId = -448, Guid = "700cbc96-fcfe-4ec7-b4cd-fc3eb8a98e40"},
                    new DataItem {QueryId = -461, Guid = "df8905a5-7e58-4c42-a39d-8123601477d7"},
                    new DataItem {QueryId = -459, Guid = "fdd2fa70-27b7-4399-ba3c-3b0b1bc7360b"},
                    new DataItem {QueryId = -500, Guid = "977cb6c0-f895-4d27-a297-0b85690cb289"},
                    new DataItem {QueryId = -497, Guid = "b28ef54d-40bd-41e9-b4b4-73d2bf2a355c"},
                    new DataItem {QueryId = -493, Guid = "ed436f22-7c9f-4f44-a17c-49cb425c4d65"},
                    new DataItem {QueryId = -420, Guid = "bc7538f2-9ef5-4ee2-86b8-ed3ca83fd971"},
                    new DataItem {QueryId = -422, Guid = "36d0c6a6-8a5c-4586-b0d5-917a9aff9557"},
                    new DataItem {QueryId = -710, Guid = "099d9a5b-3ac2-4acb-9192-5b6d7fafda34"},
                    new DataItem {QueryId = -768, Guid = "96d8cd55-3e74-4e26-a1b7-62189556df0c"},
                    new DataItem {QueryId = -769, Guid = "ea00a8ee-1248-42b5-9954-439a93fb14d8"},
                    new DataItem {QueryId = -770, Guid = "a86e3035-578c-4dfe-a147-2776af6de6e1"},
                    new DataItem {QueryId = -371, Guid = "26cf3a5c-3bbd-4239-b74f-f776df950ac8"},
                    new DataItem {QueryId = -775, Guid = "bc7538f2-9ef5-4ee2-86b8-ed3ca83fd971"},
                    new DataItem {QueryId = -772, Guid = "937f2173-5e39-48b6-bb3a-ecfd8f052bb0"},
                    new DataItem {QueryId = -776, Guid = "df8905a5-7e58-4c42-a39d-8123601477d7"},
                    new DataItem {QueryId = -774, Guid = "bc7538f2-9ef5-4ee2-86b8-ed3ca83fd971"},
                    new DataItem {QueryId = -778, Guid = "9da2fccb-d20c-4e74-9f59-349d799e25cf"},
                    new DataItem {QueryId = -812, Guid = "e3330147-aa23-4c8b-b7e8-51fdab57e7b4"},
                    new DataItem {QueryId = -817, Guid = "df8905a5-7e58-4c42-a39d-8123601477d7"},
                    new DataItem {QueryId = -810, Guid = "bbe58089-1a45-458f-81d2-12ad6c3c797c"},
                    new DataItem {QueryId = -811, Guid = "e2c41ebb-f288-4a3d-a901-360be6e630f5"},
                    new DataItem {QueryId = -804, Guid = "df8905a5-7e58-4c42-a39d-8123601477d7"},
                    new DataItem {QueryId = -805, Guid = "1fd3358c-722f-4e61-899f-26b7818b940c"},
                    new DataItem {QueryId = -815, Guid = "64071685-f105-4cf1-8196-b2599d534d46"},
                    new DataItem {QueryId = -786, Guid = "0cc358fe-0396-4142-bab5-ad327920b340"},
                    new DataItem {QueryId = -780, Guid = "97b5eafb-970d-4436-ae7f-3141f057e410"},
                    new DataItem {QueryId = -793, Guid = "700cbc96-fcfe-4ec7-b4cd-fc3eb8a98e40"},
                    new DataItem {QueryId = -802, Guid = "df8905a5-7e58-4c42-a39d-8123601477d7"},
                    new DataItem {QueryId = -838, Guid = "977cb6c0-f895-4d27-a297-0b85690cb289"},
                    new DataItem {QueryId = -835, Guid = "b28ef54d-40bd-41e9-b4b4-73d2bf2a355c"},
                    new DataItem {QueryId = -831, Guid = "ed436f22-7c9f-4f44-a17c-49cb425c4d65"},
                    new DataItem {QueryId = -765, Guid = "bc7538f2-9ef5-4ee2-86b8-ed3ca83fd971"},
                    new DataItem {QueryId = -767, Guid = "36d0c6a6-8a5c-4586-b0d5-917a9aff9557"}
                };
            return dataList;
        }
    }
}